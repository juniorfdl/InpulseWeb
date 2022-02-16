using System.ComponentModel.DataAnnotations;

namespace Inpulse.Autentication.Domain
{

    public class Usuarios
    {    
        
        [Key]
        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Tenant_id { get; set; }
        public string Login { get; set; }      
        

    }

}