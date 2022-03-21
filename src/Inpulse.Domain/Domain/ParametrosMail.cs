using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inpulse.Domain
{

    [Table("parametros_mail")]
    public class ParametrosMail: IEntidadeBase
    {   
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("CODIGO")] 
        public int Id { get; set; }
        public string Host { get; set; }
        public string Confirmacaoleitura {get;set;}
        public string Enderecocopia {get;set;}
        public string EnderecoCopiaOculta {get;set;}
        public string Autenticar {get;set;}
        public int Porta {get;set;}
        public string Prioridade {get;set;}
        public string Protocolo_SSL {get;set;}
        public string Protocolo_TLS {get;set;}
        public string Alterar_Dados_Email {get;set;}
    }

}