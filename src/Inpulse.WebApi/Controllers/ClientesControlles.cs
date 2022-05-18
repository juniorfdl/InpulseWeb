
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Inpulse.Domain;
using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using Inpulse.WebApi.Data;
using Inpulse.WebApi.Base;

namespace Inpulse.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClientesController : CrudControllerBase<Clientes>
    {
        private readonly DataContext _context;

        public ClientesController([FromServices] DataContext context)
        {
            _context = context;
        }
        protected override Clientes TrazerDadosParaEdicao(Clientes item)
        {
            if (item.CodResultado > 0)
            {
                var ret = _context.Resultados.Where(r => r.Id == item.CodResultado).FirstOrDefault();
                item.Resultado = ret?.Nome;
            }
            
            return item;
        }
    }    
}