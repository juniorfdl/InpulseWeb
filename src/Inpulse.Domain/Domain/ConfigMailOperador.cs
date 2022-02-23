using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inpulse.Domain
{

    [Table("config_mail_operador")]
    public class ConfigMailOperador: IEntidadeBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("CODIGO")] 
        public int Id { get; set; }
        public int CodigoOperadores {get;set;}
        public int CodigoConfigEmail {get;set;}
    }

}