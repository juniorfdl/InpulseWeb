using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inpulse.Domain
{

    public class Excecoes: IEntidadeBase
    {    
        
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [NotMapped]
        public int Id { get; set; }
        [Key]
        [Column("COD_ERP")]
        public string CodERP { get; set; }
    }

}