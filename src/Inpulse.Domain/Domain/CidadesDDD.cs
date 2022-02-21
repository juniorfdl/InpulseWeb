using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inpulse.Domain
{
    [Table(name:"cidades_ddd")]
    public class CidadesDDD: IEntidadeBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("cidade")] 
        public int Id { get; set; }
    }

}