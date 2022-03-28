using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inpulse.Domain
{

    public class Unidades: IEntidadeBase
    {    
        
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("CODIGO")] 
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string Email { get; set; }
        public string Contato_Mail { get; set; }
        public int Inativos_Recentes { get; set; }
        public int Inativos_Antigos { get; set; }
        public int? Operador { get; set; }
    }

}