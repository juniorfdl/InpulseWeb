using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inpulse.Domain
{

    public class Licenca: IEntidadeBase
    {    
        
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("CODIGO")] 
        public int Id { get; set; }
        public string SerialNumberHD { get; set; }
        public string NomeComputador { get; set; }
        public string DataAtual { get; set; }
        public string DataFinal { get; set; }
    }

}