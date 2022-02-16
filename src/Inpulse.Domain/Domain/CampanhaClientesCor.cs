using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inpulse.Domain
{
    [Table("campanha_clientes_cor")]
    public class CampanhaClientesCor: IEntidadeBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("cod_campanha_cor")] 
        public int Id { get; set; }
        public string Cor { get; set; }
        public int Agenda { get; set; }
    }
}