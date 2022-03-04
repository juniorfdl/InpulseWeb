using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inpulse.Domain
{

    public class Grupos: IEntidadeBase
    {  
        
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("CODIGO")] 
        public int Id { get; set; }
        public string Descricao { get; set; }
    }

}