
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
                var ret = _context.Resultados.FirstOrDefault(r => r.Id == item.CodResultado);
                item._Resultado = ret?.Nome;
            }
            
            if (item.CodUnidade > 0)
            {
                var ret = _context.Unidades.FirstOrDefault(r => r.Id == item.CodUnidade);
                item._Campanha = ret?.Descricao;
            }

            if (item.CodCampanha > 0)
            {
                var ret = _context.Campanhas.FirstOrDefault(r => r.Id == item.CodCampanha);
                item._Carteira = ret?.Nome;
            }
            
            if (item.Grupo > 0)
            {
                var ret = _context.Grupos.FirstOrDefault(r => r.Id == item.Grupo);
                item._Grupo = ret?.Descricao;
            }
            
            if (item.Origem > 0)
            {
                var ret = _context.OrigensSGR.FirstOrDefault(r => r.Id == item.Origem);
                item._Origem = ret?.Descricao;
            }
            
            if (item.CodMidia > 0)
            {
                var ret = _context.Midias.FirstOrDefault(r => r.Id == item.CodMidia);
                item._Midia = ret?.Nome;
            }
            
            if (item.Operador > 0)
            {
                var ret = _context.Operadores.FirstOrDefault(r => r.Id == item.Operador);
                item._Operador = ret?.NOME;
            }
            
            if (item.Segmento > 0)
            {
                var ret = _context.Segmentos.FirstOrDefault(r => r.Id == item.Segmento);
                item._Segmento = ret?.Nome;
            }
            
            return item;
        }
    }    
}