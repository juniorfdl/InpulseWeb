using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inpulse.Domain
{

    [Table("operadores_ligacoes")]
    public class OperadoresLigacoes: IEntidadeBase
    {    
        
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("CODIGO")] 
        public int Id { get; set; }
        public int Operador { get; set; }
        public DateTime Inicio {get;set;}
        public DateTime? Fim {get;set;}
        
    }

}