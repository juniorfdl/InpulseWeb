using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Inpulse.Domain;
using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Inpulse.WebApi.Data;

namespace Inpulse.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TenantsController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        [ResponseCache(VaryByHeader = "User-Agent", Location = ResponseCacheLocation.Any, Duration = 30)]
        public async Task<ActionResult<List<Tenants>>> Get([FromServices] DataContext context)
        {
            var tenants = await context.Tenants.AsNoTracking().ToListAsync();
            return tenants;
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<ActionResult<Tenants>> GetById([FromServices] DataContext context, int id)
        {
            var tenants = await context.Tenants.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
            return tenants;
        }

        [HttpPost]
        [Route("")]
        public async Task<ActionResult<Tenants>> Post(
            [FromServices] DataContext context,
            [FromBody]Tenants model)
        {
            if (!ModelState.IsValid)
              return BadRequest(ModelState);

            try
            {
                context.Tenants.Add(model);
                await context.SaveChangesAsync();
                return model;
            }
            catch (Exception)
            {
                return BadRequest(new { message = "Não foi possível criar Tenant" });
            }
        }
        [HttpPut]
        [Route("{id:int}")]
        public async Task<ActionResult<Tenants>> Put(
            [FromServices] DataContext context,
            int id,
            [FromBody]Tenants model)
        {
            if (id != model.Id)
                return NotFound(new { message = "Tenant não encontrado" });

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                context.Entry<Tenants>(model).State = EntityState.Modified;
                await context.SaveChangesAsync();
                return model;
            }
            catch (DbUpdateConcurrencyException)
            {
                return BadRequest(new { message = "Não foi possível atualizar Tenant" });

            }
        }

        [HttpDelete]
        [Route("{id:int}")]
        public async Task<ActionResult<Tenants>> Delete(
            [FromServices] DataContext context,
            int id)
        {
            var category = await context.Tenants.FirstOrDefaultAsync(x => x.Id == id);
            if (category == null)
                return NotFound(new { message = "Tenant não encontrado" });

            try
            {
                context.Tenants.Remove(category);
                await context.SaveChangesAsync();
                return category;
            }
            catch (Exception)
            {
                return BadRequest(new { message = "Não foi possível remover a Tenant" });

            }
        }
    }    
}