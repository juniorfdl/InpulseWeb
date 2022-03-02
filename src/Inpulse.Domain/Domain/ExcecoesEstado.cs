using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inpulse.Domain
{

    [Table("excecoes_estado")]
    public class ExcecoesEstado: IEntidadeBase
    {    
        
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [NotMapped]
        public int Id { get; set; }
        [Key]
        public string Estado { get; set; }
    }

}