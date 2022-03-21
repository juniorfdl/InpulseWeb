using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inpulse.Domain
{

    [Table("parametros_envio_relatorios")]
    public class ParametrosEnvioRelatorios: IEntidadeBase
    {    
        
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("CODIGO")] 
        public int Id { get; set; }
        public string Periodicidade_Rel_Produtividade {get;set;}
        public string Periodicidade_Rel_Regua {get;set;}
        public string Lista_Emails {get;set;}
        public string Nome_Exibicao {get;set;}
        public string Email_Exibicao {get;set;}
        public string Email {get;set;}
        public string Senha {get;set;}
        public string Caminho_Arquivos {get;set;}
        public string Envio_Relatorio_Produtividade {get;set;}
        public string Envio_Relatorio_Regua {get;set;}
        public string Assunto {get;set;}
        public string Corpo_Email {get;set;}
        public string Excluir_Arquivos_Antigos {get;set;}
    }

}