using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inpulse.Domain
{
    [Table("fone_digito")]
    public class FoneDigito: IEntidadeBase
    {   
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [NotMapped] 
        public int Id { get; set; }
        [Key]
        public string UF { get; set; }
        [Key]
        public string DDD { get; set; }
        [Key]
        public string DIGITO { get; set; }
    }
}