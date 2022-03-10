using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inpulse.Domain
{

    [Table("operadores")]
    public class Usuarios: IEntidadeBase
    {
        [Key]
        [Column("CODIGO")]
        public int Id { get; set; }
        public string Login { get; set; }
        public string Nivel { get; set; }
    }
    
    public class LoginInputModelDto
    {
        public LoginInputModelDto() { }

        public LoginInputModelDto(string user, string senha)
        {
            User = user;
            Senha = senha;
        }

        [Required]
        public string User { get; set; }
        [Required]
        public string Senha { get; set; }
    }

}