using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Inpulse.Domain;
using Inpulse.WebApi.Data;
using Inpulse.WebApi.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Primitives;
using MySqlConnector;
using Newtonsoft.Json;

namespace Inpulse.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RelatoriosController : CrudControllerBase<Relatorios>
    {
        private string DataTableToJsonWithJsonNet(DataTable table) {  
            string jsonString = string.Empty;
            jsonString = JsonConvert.SerializeObject(table);
            return jsonString; 
        }
        
        [HttpGet]
        [Route("Consultar/{id:int}")]
        public async Task<ActionResult<string>> ConsultarRelatorio([FromServices] DataContext context, 
            [FromServices] IConfiguration configuration, int id, string filter)
        {
            var relatorio = await context.Set<Relatorios>().AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);

            if (relatorio == null)
                throw new Exception("Relatório não encontrado");

            var colunas = await context.Set<RelatoriosColunas>().AsNoTracking()
                .Where(x => x.Id_Relatorio == id && x.Visivel == "S")
                .ToListAsync();

            StringBuilder sql = new StringBuilder();
            sql.AppendLine("select");
            var virgula = "";
            foreach (var col in colunas)
            {
                sql.Append(virgula);
                sql.AppendLine(col.Nome);
                virgula = ",";
            }
            
            sql.AppendLine($"from {relatorio.Objeto_Database}");
            
            if (filter != String.Empty)
            {
                sql.AppendLine("where");
                sql.AppendLine(filter);
            }

            using (MySqlConnection conn = new MySqlConnection(configuration.GetConnectionString("DefaultConnection")))
            {
                string esqlQuery = sql.ToString();
                
                using (MySqlCommand cmd = new MySqlCommand(esqlQuery, conn))
                {
                    await conn.OpenAsync();
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        var table = new DataTable();
                        table.BeginLoadData();
                        table.Load(reader);
                        table.EndLoadData();
                        return Ok(DataTableToJsonWithJsonNet(table));
                    }
                }
            }
        }
        
    }    
}