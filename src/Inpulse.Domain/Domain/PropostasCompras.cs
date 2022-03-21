using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inpulse.Domain
{

    [Table("propostas_compras")]
    public class PropostasCompras: IEntidadeBase
    {   
        [Column("proposta")] 
        public int Id { get; set; }
        public int Compra { get; set; }
    }

}