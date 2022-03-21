using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inpulse.Domain
{

    [Table("operadores_status")]
    public class OperadoresStatus: IEntidadeBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("OPERADOR")]
        public int Id { get; set; }
        public string Status_Atual { get; set; }
        public TimeSpan? Tempo { get; set; }
    }

}