using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inpulse.Domain
{

    public class Cidades: IEntidadeBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("CODIGO")] 
        public int Id { get; set; }
        public string Nome {get;set;}
        public string UF {get;set;}
        public int? OrdemEstado {get;set;}
        public int? Ordem {get;set;}
        public int? OrdemCidade {get;set;}
    }

}