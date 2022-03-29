using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inpulse.Domain
{

    public class Vendas: IEntidadeBase
    {    
        
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Pagamento { get; set; }
    }

}