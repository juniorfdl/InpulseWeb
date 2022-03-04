using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inpulse.Domain
{

    [Table("fone_areas")]
    public class FoneAreas: IEntidadeBase
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [NotMapped]
        public int Id { get; set; }
        [Key]
        public string Codigo { get; set; }
        public string Descricao { get; set; }
    }
}