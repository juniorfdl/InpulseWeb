using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inpulse.Domain
{

    [Table("operadores_meta")]
    public class OperadoresMeta: IEntidadeBase
    {    
        
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("CODIGO")] 
        public int Id { get; set; }
        public int Operador { get; set; }
        public string Mes { get; set; }
        public int Ano { get; set; }
        public double Valor_Meta { get; set; }
    }

}