using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inpulse.Domain
{

    [Table("operadores_espera")]
    public class OperadoresEspera: IEntidadeBase
    {    
        
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("OPERADOR")] 
        public int Id { get; set; }
        [Column("OPERADOR_PEDIDO")]
        public int OperadorPedido { get; set; }
    }

}