
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Inpulse.Autentication.Domain;
using System;
using Microsoft.EntityFrameworkCore;
using Inpulse.Autentication.WebApi.Data;
using System.Collections.Generic;

namespace Inpulse.Autentication.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuariosController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        [ResponseCache(VaryByHeader = "User-Agent", Location = ResponseCacheLocation.Any, Duration = 30)]
        public async Task<ActionResult<List<Usuarios>>> Get([FromServices] DataContext context)
        {
            var usuarios = await context.Usuarios.AsNoTracking().ToListAsync();
            return usuarios;
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<ActionResult<Usuarios>> GetById([FromServices] DataContext context, int id)
        {
            var usuario = await context.Usuarios.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
            return usuario;
        }

        [HttpPost]
        [Route("")]
        public async Task<ActionResult<Usuarios>> Post(
            [FromServices] DataContext context,
            [FromBody]Usuarios model)
        {
            if (!ModelState.IsValid)
              return BadRequest(ModelState);

            try
            {
                context.Usuarios.Add(model);
                await context.SaveChangesAsync();
                return model;
            }
            catch (Exception)
            {
                return BadRequest(new { message = "Não foi possível criar a Usuario" });
            }
        }
        [HttpPut]
        [Route("{id:int}")]
        public async Task<ActionResult<Usuarios>> Put(
            [FromServices] DataContext context,
            int id,
            [FromBody]Usuarios model)
        {
            if (id != model.Id)
                return NotFound(new { message = "Usuário não encontrado" });

            // Verifica se os dados são válidos
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                context.Entry<Usuarios>(model).State = EntityState.Modified;
                await context.SaveChangesAsync();
                return model;
            }
            catch (DbUpdateConcurrencyException)
            {
                return BadRequest(new { message = "Não foi possível atualizar a Usuario" });

            }
        }

        [HttpDelete]
        [Route("{id:int}")]
        public async Task<ActionResult<Usuarios>> Delete(
            [FromServices] DataContext context,
            int id)
        {
            var category = await context.Usuarios.FirstOrDefaultAsync(x => x.Id == id);
            if (category == null)
                return NotFound(new { message = "Usuário não encontrado" });

            try
            {
                context.Usuarios.Remove(category);
                await context.SaveChangesAsync();
                return category;
            }
            catch (Exception)
            {
                return BadRequest(new { message = "Não foi possível remover a Usuario" });

            }
        }
    }    
}