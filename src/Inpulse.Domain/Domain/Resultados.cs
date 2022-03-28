using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inpulse.Domain
{

    public class Resultados: IEntidadeBase
    {   
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("CODIGO")] 
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Tipo { get; set; }
        public string ESucesso { get; set; }
        public string EVenda { get; set; }
        public string Nome_Acao {get;set;}
        public string EContato { get; set; }
        public int? Cod_Acao {get;set;}
        public string Prioridade {get;set;}
        public string Proposta {get;set;}
        public string FidelizarCotacao {get;set;}
        public int Qtde_FidelizarCotacao {get;set;}
        public string Altera_Duracao {get;set;}
        public string Pesquisa_Satisfacao {get;set;}
        public string EPedido {get;set;}
    }

}