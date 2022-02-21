using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inpulse.Domain
{
    [Table(name:"chamadas_receptivo")]
    public class ChamadasReceptivo: IEntidadeBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("CODIGO")] 
        public int Id {get;set;}
        public int Operador {get;set;}
        public int Cliente {get;set;}
        public int Resultado {get;set;}
        [Column(name:"TEMPO_EXCEDIDO")]
        public TimeSpan TempoExcedido {get;set;}
        [Column(name:"FONE_RECEPTIVO")]
        public string FoneReceptivo {get;set;}
        [Column(name:"LIGACAO_RECEBIDA")]
        public DateTime? LigacaoRecebida {get;set;}
        [Column(name:"LIGACAO_FINALIZADA")]
        public DateTime? LigacaoFinalizada {get;set;}
        [Column(name:"TIPO_ACAO")]
        public string TipoAcao {get;set;}
        public string Obs {get;set;}
        
    }
}