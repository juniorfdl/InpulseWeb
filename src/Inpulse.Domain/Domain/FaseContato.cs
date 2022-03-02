using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inpulse.Domain
{

    [Table("fase_contato")]
    public class FaseContato: IEntidadeBase
    {    
        
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("CODIGO")] 
        public int Id { get; set; }
        public string Nome { get; set; }
        [Column("EXIGE_OBSERVACAO")]
        public string ExigeObservacao { get; set; }
    }

}