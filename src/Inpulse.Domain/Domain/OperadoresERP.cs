using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inpulse.Domain
{

    [Table("operadores_erp")]
    public class OperadoresERP: IEntidadeBase
    {    
        
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("COGIGO")] 
        public int Id { get; set; }
        public int Operador {get;set;}
        public string Cod_Erp {get;set;}
    }

}