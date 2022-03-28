using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inpulse.Domain
{

    [Table("transferencia_clientes")]
    public class TransferenciaClientes: IEntidadeBase
    {    
        
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("CODIGO")] 
        public int Id { get; set; }
        public DateTime DATA_HORA { get; set; }
        public int Operador { get; set; }
        public int Operador_Origem { get; set; }
        public int Operador_Destino { get; set; }
    }

}