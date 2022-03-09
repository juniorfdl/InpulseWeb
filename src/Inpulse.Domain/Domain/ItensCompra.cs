using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inpulse.Domain
{

    [Table("itens_compra")]
    public class ItensCompra: IEntidadeBase
    {    
        
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("CODIGO")] 
        public int Id { get; set; }
        public int Nota {get;set;}
        public string CodProd {get;set;}
        public string Descricao {get;set;}
        public int QDT {get;set;}
        public string Un_Medida {get;set;}
        public double Valor_Un {get;set;}
        public double Desconto {get;set;}
    }

}