using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inpulse.Domain
{

    [Table("login_ativo_receptivo")]
    public class LoginAtivoReceptivo: IEntidadeBase
    {    
        
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("CODIGO")] 
        public int Id { get; set; }
        public DateTime Entrada {get;set;}
        public DateTime Saida {get;set;}
        public TimeSpan? Tempo_Logado {get;set;}
        public int Ligacoes_Ok {get;set;}
        public int Ligacoes_Perdidas {get;set;}
        public int Operador {get;set;}
        public string Modulo {get;set;}
        public TimeSpan? Tempo_Ligacao {get;set;}
    }

}