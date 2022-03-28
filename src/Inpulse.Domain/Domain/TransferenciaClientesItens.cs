using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inpulse.Domain
{

    [Table("transferencia_clientes_itens")]
    public class TransferenciaClientesItens: IEntidadeBase
    {    
        
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("CODIGO")] 
        public int Id { get; set; }
        public int Cliente { get; set; }
    }

}