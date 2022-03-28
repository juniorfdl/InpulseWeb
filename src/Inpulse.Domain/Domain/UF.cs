using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inpulse.Domain
{

    public class UF: IEntidadeBase
    {    
        
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [NotMapped]
        public int Id { get; set; }
        [Key]
        public string uf { get; set; }
        public string Nome { get; set; }
        public int FusoHorario { get; set; }
    }

}