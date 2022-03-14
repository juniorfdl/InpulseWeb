using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inpulse.Domain
{

    [Table("Operadores_Foto")]
    public class OperadoresFoto: IEntidadeBase
    {    
        
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("OPERADOR")] 
        public int Id { get; set; }
        public Byte[] Foto { get; set; }
    }

}