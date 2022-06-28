using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inpulse.Domain
{

    [Table("RELATORIOS_COLUNAS")]
    public class RelatoriosColunas: IEntidadeBase
    {    
        
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int Id_Relatorio { get; set; }
        public string Nome { get; set; }
        public string Titulo { get; set; }
        public string Obrigatorio { get; set; }
        public string Visivel { get; set; }
    }

}