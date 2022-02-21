using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inpulse.Domain
{
    [Table(name:"clientes_base")]
    public class ClientesBase: IEntidadeBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("CODIGO")] 
        public int Id { get; set; }
        public int Campanha {get;set;}
        public int Unidade {get;set;}
        public int Quantidade {get;set;}
        public int Ano {get;set;}
        public int Mes {get;set;}
    }

}