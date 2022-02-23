using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inpulse.Domain
{

    [Table("clientes_marcas")]
    public class ClientesMarcas: IEntidadeBase
    {    
        
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("CODIGO")] 
        public int Id { get; set; }
        public int Cliente {get;set;}
        public int Marca {get;set;}
        [Column(name:"DATA_ULTIMA_COMPRA")]
        public DateTime? DataUltimaCompra {get;set;}
        public int? Operador {get;set;}
    }

}