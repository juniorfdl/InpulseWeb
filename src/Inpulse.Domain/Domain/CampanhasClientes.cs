using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inpulse.Domain
{

    [Table("Campanhas_Clientes")]
    public class CampanhasClientes: IEntidadeBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("CODIGO")] 
        public int Id { get; set; }
        public int Cliente { get; set; }
        public int Campanha { get; set; }
        [Column(name:"DT_RESULTADO")]
        public DateTime? DtResultado { get; set; }
        [Column(name:"DT_AGENDAMENTO")]
        public DateTime? DtAgendamento { get; set; }
        public int? Resultado { get; set; }
        public string Concluido { get; set; }
        public string Fone1 { get; set; }
        public string Fone2 { get; set; }
        public string Fone3 { get; set; }
        public string Desc_Fone1 { get; set; }
        public string Desc_Fone2 { get; set; }
        public string Desc_Fone3 { get; set; }
        public int? Ordem { get; set; }
        public int Operador { get; set; }
        public int Operador_ligacao { get; set; }
        [Column(name:"DATA_HORA_LIG")]
        public DateTime? DataHoraLig { get; set; }
        [Column(name:"TELEFONE_LIGADO")]
        public string TelefoneLigado { get; set; }
        [Column(name:"DATA_HORA_FIM")]
        public DateTime? DataHoraFim { get; set; }
        public int Agenda { get; set; }
        public string Fideliza { get; set; }
        public string Manual { get; set; }
    }
}