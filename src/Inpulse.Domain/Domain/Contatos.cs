using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inpulse.Domain
{

    public class Contatos: IEntidadeBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("CODIGO")] 
        public int Id { get; set; }
        public string Nome {get;set;}
        public int? Cargo {get;set;}
        public string Email {get;set;}
        [Column(name:"AREA_DIRETO")]
        public string AreaDireto {get;set;}
        [Column(name:"AREA_CEL")]
        public string AreaCel {get;set;}
        [Column(name:"AREA_RESI")]
        public string AreaResi {get;set;}
        [Column(name:"FONE_DIRETO")]
        public string FoneDireto {get;set;}
        public string Celular {get;set;}
        [Column(name:"FONE_RESIDENCIAL")]
        public string FoneResidencial {get;set;}
        public DateTime? Aniversario {get;set;}
        [Column(name:"TIME_FUTEBOL")]
        public string TimeFutebol {get;set;}
        public int? Filhos {get;set;}
        public int? Cliente {get;set;}
        public string Tratamento {get;set;}
    }

}