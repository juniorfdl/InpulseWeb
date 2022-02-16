using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inpulse.Domain
{

    [Table(name:"chamadas_perd")]
    public class ChamadasPerdidas: IEntidadeBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("CODIGO")] 
        public int Id { get; set; }
        public string Telefone {get;set;}
        [Column(name:"COD_OPERADOR")]
        public int CodOperador {get;set;}
        [Column(name:"DATA_HORA")]
        public DateTime? DataHora {get;set;}
        public string Modulo {get;set;}
        public string Motivo {get;set;}
        public int Cliente {get;set;}
    }

}