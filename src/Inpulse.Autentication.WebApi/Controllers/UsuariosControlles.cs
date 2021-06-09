
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Inpulse.Autentication.Domain;

namespace Inpulse.Autentication.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuariosController : ControllerBase
    {
        public ActionResult<Usuarios> MeuMetodo() => new Usuarios();

    }
}