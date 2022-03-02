using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inpulse.Domain
{

    public class Fidelizacoes: IEntidadeBase
    {    
        
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("CODIGO")] 
        public int Id {get;set;}
        public int Cliente {get;set;}
        public int cc_codigo {get;set;}
        [Column("cod_origem")]
        public int? CodOrigem {get;set;}
        [Column("qtde_fidelizar")]
        public int? QtdeFidelizar {get;set;}
        [Column("dt_criacao")]
        public DateTime? DataCriacao {get;set;}
        [Column("operador_criacao")]
        public int? OperadorCriacao {get;set;}
    }

}