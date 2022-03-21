using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inpulse.Domain
{

    [Table("prioridade_campanha")]
    public class PrioridadeCampanha: IEntidadeBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("CODIGO")] 
        public int Id { get; set; }
        public int? Cod_Campanha {get;set;}
        public string Estado {get;set;}
        public TimeSpan HoraIni {get;set;}
        public TimeSpan HoraFim {get;set;}
    }

}