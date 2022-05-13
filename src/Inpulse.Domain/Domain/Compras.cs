using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inpulse.Domain
{

    public class Compras: IEntidadeBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("CODIGO")] 
        public int Id { get; set; }
        public int Cliente {get;set;}
        public DateTime? Data {get;set;}
        public string Descricao {get;set;}
        [Column(name:"FORMA_PGTO")]
        public string FormaPgto {get;set;}
        public int? Operador {get;set;}
        public string Faturado {get;set;}
        public double? Valor { get; set; }
        public string Tipo {get;set;}
        public string Situacao {get;set;}
        public int? ClienteAtivo {get;set;}
    }

}