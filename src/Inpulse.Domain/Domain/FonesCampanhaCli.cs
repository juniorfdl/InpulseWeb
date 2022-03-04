using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inpulse.Domain
{

    [Table("fones_campanha_cli")]
    public class FonesCampanhaCli: IEntidadeBase
    {   
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("CODIGO")] 
        public int Id { get; set; }
        public int Cliente { get; set; }
        public string Fone { get; set; }
        [Column("TIPO_CONTATO")]
        public string TipoContato { get; set; }
        [Column("TIPO_FONE")]
        public string TipoFone { get; set; }
    }

}