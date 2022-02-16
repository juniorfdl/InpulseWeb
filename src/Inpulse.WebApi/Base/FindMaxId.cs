using System.Threading.Tasks;
using Inpulse.WebApi.Data;
using System.Collections.Generic;
using Inpulse.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Inpulse.WebApi.Base
{
    public static class FindMaxId<T>
        where T : class, IEntidadeBase
    {
        
        public static async int Obter([FromServices] DataContext context)
        {
            var i = await context.Set<T>().MaxAsync(p => p.Id);
            return i;
        }
        
    }
}