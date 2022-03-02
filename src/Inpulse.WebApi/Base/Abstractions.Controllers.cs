using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using Inpulse.WebApi.Data;
using Inpulse.Domain;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Hosting;

namespace Inpulse.WebApi.Base
{
    public abstract class CrudController<T, TProjecao> : ControllerBase
        where T : class, IEntidadeBase
        where TProjecao : T
    {
        protected abstract Expression<Func<T, TProjecao>> Selecionar();
        protected virtual IOrderedQueryable<TProjecao> Ordenar(IQueryable<TProjecao> query) { return query.OrderBy(it => it.Id); }
        protected virtual IQueryable<T> TrazerDadosParaEdicao(IQueryable<T> query) { return query; }
        protected virtual IQueryable<TProjecao> TrazerDadosParaLista(IQueryable<TProjecao> query) { return query; }
        protected virtual IQueryable<TProjecao> Filtrar(IQueryable<TProjecao> query, string termoDePesquisa, string campoPesquisa)
        {
            if (string.IsNullOrEmpty(termoDePesquisa) || string.IsNullOrEmpty(campoPesquisa)) return query;

            var parameter = Expression.Parameter(typeof(TProjecao), "p");
            var propertyInfo = typeof(TProjecao).GetProperty(campoPesquisa, BindingFlags.Instance | BindingFlags.Public | BindingFlags.IgnoreCase);
            var property = Expression.Property(parameter, propertyInfo);
            Expression body = null;

            var notMapped = typeof(TProjecao).GetProperty(campoPesquisa).GetCustomAttributes(typeof(NotMappedAttribute), false);

            if (notMapped.Length > 0) // testa se o campo é NotMapped, se for não faz where
            {
                return query;
            }

            try
            {
                if (campoPesquisa == "CEMP")
                {
                    body = Expression.Equal(property, Expression.Constant(termoDePesquisa));
                }
                else
                if (propertyInfo.PropertyType == typeof(int))
                {
                    var asInt32 = Convert.ToInt32(termoDePesquisa);
                    body = Expression.Equal(property, Expression.Constant(asInt32));
                }
                else
                if (propertyInfo.PropertyType == typeof(string))
                {
                    body = Expression.Call(property,
                        "Contains",
                        null,
                        Expression.Constant(termoDePesquisa));
                }
                else if (propertyInfo.PropertyType == typeof(DateTime))
                {
                    var asDateTime = Convert.ToDateTime(termoDePesquisa);
                    body = Expression.Equal(property, Expression.Constant(asDateTime));
                }
                else
                if (propertyInfo.PropertyType == typeof(Nullable<int>))
                {
                    //var asInt32 = Convert.ToInt32(termoDePesquisa);
                    //body = BuildIdPredicate<T, int>(asInt32, campoPesquisa);
                    // //var myInstance = new myClass();
                    // var equalsMethod = typeof(Int32?).GetMethod("Equals", new[] { typeof(Int32?) });
                    // int? nullableInt = Convert.ToInt32(termoDePesquisa);
                    // var nullableIntExpr = System.Linq.Expressions.Expression.Constant(nullableInt);
                     //var myInstanceExpr = System.Linq.Expressions.Expression.Constant(myInstance);
                    // var propertyExpr = property;
                    //// body = Expression.Call(propertyExpr, equalsMethod, nullableIntExpr); // This line throws the exception.     

                     //var converted = Expression.Convert(nullableIntExpr, typeof(int?));
                     //var lambda = Expression.Lambda<Func<TProjecao, bool>>(condition, parameter);
                     //body = Expression.Call(propertyExpr, equalsMethod, converted);                    
                    
                    //var asInt32 = Convert.ToInt32(termoDePesquisa);
                    //body = Expression.Equal(property, Expression.Constant(asInt32));
                }
            }
            catch (FormatException)
            {
                return query.Take(0);
            }
            var filterExp = Expression.Lambda<Func<TProjecao, bool>>(body, parameter);
            
            return query.Where(filterExp);
        }
        
        public Expression<Func<TModel, bool>> BuildIdPredicate<TModel, T2>(T2 id, string campoPesquisa)
            where TModel : class
        {
            Expression<Func<TModel, bool>> predicate = null;
            
                var value = id;
                var parameter = Expression.Parameter(typeof(TModel), typeof(TModel).Name);
                var memberExpression = Expression.Property(parameter, campoPesquisa);
                //value = value.ChangeType(memberExpression.Type);
                var condition = Expression.Equal(memberExpression, Expression.Convert(Expression.Constant(value), memberExpression.Type));
                var lambda = Expression.Lambda<Func<TModel, bool>>(condition, parameter);
                predicate = predicate?.AndAlso(lambda) ?? lambda;
            
            return predicate;
        }
        
        [HttpGet]
        [Route("")]
        [ResponseCache(VaryByHeader = "User-Agent", Location = ResponseCacheLocation.Any, Duration = 30)]
        public async Task<ActionResult<List<TProjecao>>> Get([FromServices] DataContext context, 
            string termo = null, string campoOrdenacao = null, 
            bool direcaoAsc = true,
            int pagina = 1, int itensPorPagina = 0, string campoPesquisa = "")
            //[FromUri] List<string> filtrosBaseNome = null, [FromUri] List<string> filtrosBaseValor = null)
        {
            var Item = this.Selecionar();
            var queryOriginal = context.Set<T>().AsQueryable().Select(Item);
            
            if (!string.IsNullOrWhiteSpace(termo))
            {
                queryOriginal = this.Filtrar(queryOriginal, termo, campoPesquisa);
            }
            
            // return new ResultadoDaBusca<TProjecao>
            // {
            //     lista = this.TrazerDadosParaLista(queryRetorno),
            //     totalCount = queryOriginal.Count()
            // };
            var queryRetorno = queryOriginal;
            var dados = await this.TrazerDadosParaLista(queryRetorno).ToListAsync();
            
            //Response.Headers.Add("X-Pagination", JsonConvert.SerializeObject(paginationMetadata, SerializationHelper.SerializerSettings));
            
            //dados.totalCount = queryOriginal.Count();
            //var dados = await context.Set<T>().AsNoTracking().ToListAsync();
            return Ok(dados);
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<ActionResult<TProjecao>> GetById([FromServices] DataContext context, int id)
        {
            var dados = await context.Set<T>().AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
            return Ok(dados);
        }

        [HttpPost]
        [Route("")]
        public async Task<ActionResult<TProjecao>> Post(
            [FromServices] DataContext context,
            [FromBody] T model,
            [FromServices] IWebHostEnvironment env)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                await ProcessarAntesPost(context, model);
                
                if (model.Id == 0)
                {
                    model.Id = await SelectMaxCompositeKeyAsync<T>(context, model);
                    model.Id++;
                }

                context.Set<T>().Add(model);
                await context.SaveChangesAsync();
                return Ok(model);
            }
            catch (Exception e)
            {
                var msg = env.IsDevelopment() ? e.ToString() :
                    e.InnerException != null ? e.InnerException?.Message : e.Message;

                return BadRequest(new {message = "Não foi possível criar o registro", error = msg});
            }
        }
        
        private static async Task<int> SelectMaxCompositeKeyAsync<TModel>(DbContext dbContext, TModel model)
            where TModel : class
        {
            var entityType = dbContext.Model.FindEntityType(typeof(TModel));
            var maxKey = GetExpressionMax<TModel, int>("Id");
            var query = dbContext.Set<TModel>().AsQueryable();
            var keys = entityType.FindPrimaryKey().Properties;
            query = AddWhereForPk(query, model, keys, keys.Count);
            return await query.MaxAsync(maxKey) ?? default;
        }
        private static IQueryable<TModel> AddWhereForPk<TModel>(IQueryable<TModel> query, TModel model,
            IReadOnlyList<IProperty> keys, int keysCount)
            where TModel : class
        {
            var param = Expression.Parameter(typeof(TModel));
            for (var i = 0; i < keysCount - 1; i++) query = AddWhereForPkProperty(query, model, param, keys[i]);
            return query;
        }
        
        private static IQueryable<TModel> AddWhereForPkProperty<TModel>(IQueryable<TModel> query, TModel model, ParameterExpression param, IPropertyBase key)
            where TModel : class
        {
            var pkProperty = Expression.Property(param, key.Name);
            var pkValue = key.PropertyInfo.GetValue(model);
            var valueExpression = Expression.Convert(Expression.Constant(pkValue), key.PropertyInfo.PropertyType);
            var body = Expression.Equal(pkProperty, valueExpression);
            var wherePk = Expression.Lambda<Func<TModel, bool>>(body, param);
            return query.Where(wherePk);
        }
        private static Expression<Func<TModel, TRetorno?>> GetExpressionMax<TModel, TRetorno>(string propertyName)
            where TRetorno : struct
        {
            var parameter = Expression.Parameter(typeof(TModel));
            var propertyReference = Expression.Convert(Expression.Property(parameter, propertyName), typeof(TRetorno?));
            return Expression.Lambda<Func<TModel, TRetorno?>>(propertyReference, parameter);
        }
        
        protected virtual async Task ProcessarAntesPost(DataContext context, T model)
        { 
            await Task.FromResult(1);
        }
        
        [HttpPut]
        [Route("{id:int}")]
        public async Task<ActionResult<TProjecao>> Put(
            [FromServices] DataContext context,
            int id,
            [FromBody] T model)
        {
            if (id != model.Id)
                return NotFound(new {message = "Registro não encontrado"});

            // Verifica se os dados são válidos
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                context.Entry<T>(model).State = EntityState.Modified;
                await context.SaveChangesAsync();
                return Ok(model);
            }
            catch (DbUpdateConcurrencyException)
            {
                return BadRequest(new {message = "Não foi possível atualizar o registro"});
            }
        }

        [HttpDelete]
        [Route("{id:int}")]
        public async Task<ActionResult<TProjecao>> Delete(
            [FromServices] DataContext context,
            int id)
        {
            var dados = await context.Set<T>().FirstOrDefaultAsync(x => x.Id == id);
            if (dados == null)
                return NotFound(new {message = "Registro não encontrado"});

            try
            {
                context.Set<T>().Remove(dados);
                await context.SaveChangesAsync();
                return Ok(dados);
            }
            catch (Exception)
            {
                return BadRequest(new {message = "Não foi possível remover o registro"});
            }
        }
    }
    
    public abstract class CrudControllerBase<T> : CrudController<T, T>
        where T : class, IEntidadeBase
    {
        protected override Expression<Func<T, T>> Selecionar()
        {
            return item => item;
        }
    }
}