using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inpulse.Domain
{

    [Table("historico_cli")]
    public class HistoricoCli: IEntidadeBase
    {    
        
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("CODIGO")] 
        public int Id { get; set; }
        public string Campanha { get; set; }
        public string Operador {get;set;}
        [Column("DATAHORA_INICIO")]
        public DateTime? DataHoraInicio {get;set;}
        [Column("DATAHORA_FIM")]
        public DateTime? DataHoraFim {get;set;}
        public int? Resultado {get;set;}
        public string Telefone {get;set;}
        public int Cliente {get;set;}
        [Column("CODIGO_FASE_CONTATO")]
        public int? CodigoFaseContato {get;set;}
        public int? CC_CODIGO {get;set;}
        public int? Marca {get;set;}
    }

}