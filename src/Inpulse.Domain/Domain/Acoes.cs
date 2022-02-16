using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inpulse.Domain
{

    public class Acoes: IEntidadeBase
    {    
        
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("CODIGO")] 
        public int Id { get; set; }
        public string Descricao { get; set; }
    }

}