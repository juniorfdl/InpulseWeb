using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inpulse.Domain
{

    public class Consultas: IEntidadeBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("CODIGO")] 
        public int Id { get; set; }
        [Column(name:"DATA_CONSULTA")]
        public DateTime? DataConsulta {get;set;}
        public string Titulo {get;set;}
        public string Obs {get;set;}
        [Column(name:"COMANDO_SQL")]
        public string ComandoSql {get;set;}
    }

}