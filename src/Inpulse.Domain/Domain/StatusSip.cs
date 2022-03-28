using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inpulse.Domain
{

    [Table("status_sip")]
    public class StatusSip: IEntidadeBase
    {    
        
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id_status")] 
        public int Id { get; set; }
        public int? cod_status_sip { get; set; }
        public string Descricao { get; set; }
    }

}