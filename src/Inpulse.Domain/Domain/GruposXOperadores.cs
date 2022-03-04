using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inpulse.Domain
{

    public class GruposXOperadores: IEntidadeBase
    {    
        
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("CODIGO")] 
        public int Id { get; set; }
        public int Grupo { get; set; }
        public int Operador { get; set; }
    }

}