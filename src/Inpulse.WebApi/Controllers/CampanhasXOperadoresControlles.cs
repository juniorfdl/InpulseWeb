
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Inpulse.Domain;
using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Inpulse.WebApi.Data;
using Inpulse.WebApi.Base;

namespace Inpulse.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CampanhasXOperadoresController : CrudControllerBase<CampanhasXOperadores>
    {
        protected override async Task ProcessarAntesPost(DataContext context, CampanhasXOperadores model)
        {
            var id = await context.Set<CampanhasXOperadores>().MaxAsync(p => p.Id);
            model.Id = ++id;
        }
    }    
}