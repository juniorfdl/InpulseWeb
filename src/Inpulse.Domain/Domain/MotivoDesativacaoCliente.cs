using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inpulse.Domain
{

    [Table("motivo_desativacao_cliente")]
    public class MotivoDesativacaoCliente: IEntidadeBase
    {    
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [NotMapped] 
        public int Id { get; set; }
        public int Operador { get; set; }
        public int Cliente { get; set; }
        public DateTime DataHora { get; set; }
        public string Motivo { get; set; }
    }

}