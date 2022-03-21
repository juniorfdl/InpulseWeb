using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inpulse.Domain
{

    [Table("pausas_realizadas")]
    public class PausasRealizadas: IEntidadeBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("CODIGO")] 
        public int Id { get; set; }
        public int Operador {get;set;}
        public DateTime Data_Hora {get;set;}
        public string OBS {get;set;}
        public int Cod_Pausa {get;set;}
        public TimeSpan? Tempo_Exedido {get;set;}
        public DateTime? Data_Hora_Fim {get;set;}
    }

}