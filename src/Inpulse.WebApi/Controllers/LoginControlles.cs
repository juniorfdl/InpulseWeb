
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Inpulse.Domain;
using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Inpulse.WebApi.Data;
using Inpulse.WebApi.Base;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;

namespace Inpulse.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoginController : ControllerBase
    {
        [HttpPost]
        [AllowAnonymous]
        [Route("")]
        public async Task<ActionResult<Usuarios>> Login(
            [FromServices] DataContext context,
            [FromBody] LoginInputModelDto login
        )
        {
            try
            {
                var dados = await context.Set<Operadores>().AsNoTracking()
                    .FirstOrDefaultAsync(x => x.LOGIN == login.User 
                                              && x.SENHA == login.Senha
                                              && x.ATIVO == "SIM");
                
                if (dados == null)
                    return BadRequest();
                
                Usuarios result = new Usuarios
                {
                    Id = dados.Id, Login = dados.LOGIN, Nivel = dados.NIVEL
                };

                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }    
}