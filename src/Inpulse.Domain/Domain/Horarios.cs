using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inpulse.Domain
{

    public class Horarios: IEntidadeBase
    {    
        
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("CODIGO")] 
        public int Id { get; set; }
        public TimeSpan? Entrada_1 {get;set;}
        public TimeSpan? Entrada_2 {get;set;}
        public TimeSpan? Entrada_3 {get;set;}
        public TimeSpan? Saida_1 {get;set;}
        public TimeSpan? Saida_2 {get;set;}
        public TimeSpan? Saida_3 {get;set;}
        public string Descricao {get;set;}
    }

}