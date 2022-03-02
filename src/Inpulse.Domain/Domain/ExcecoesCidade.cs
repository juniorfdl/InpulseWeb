using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inpulse.Domain
{

    [Table("excecoes_cidade")]
    public class ExcecoesCidade: IEntidadeBase
    {    
        
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [NotMapped]
        public int Id { get; set; }
        [Key]
        public string Cidade { get; set; }
    }

}