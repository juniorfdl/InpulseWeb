using System.ComponentModel.DataAnnotations;

namespace Inpulse.Domain
{

    public class Usuarios: IEntidadeBase
    {    
        
        [Key]
        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Tenant_id { get; set; }
        public string Login { get; set; }

    }

}