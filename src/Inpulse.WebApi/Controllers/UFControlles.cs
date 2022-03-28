
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
    public class UFController : CrudControllerBase<UF>
    {
        protected override async Task ProcessarAntesPost(DataContext context, UF model)
        { 
            model.Id = 1;
            await Task.FromResult(1);
        }
    }    
}