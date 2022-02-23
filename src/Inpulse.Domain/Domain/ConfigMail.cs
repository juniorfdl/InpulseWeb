using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inpulse.Domain
{
    [Table("config_mail")]
    public class ConfigMail: IEntidadeBase
    {   
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("CODIGO")] 
        public int Id { get; set; }
        public string Copia {get;set;}
        public string CopiaOculta {get;set;}
        public string Texto {get;set;}
        public string Host {get;set;}
        public string Usuario {get;set;}
        public string Pass {get;set;}
        public int? Port {get;set;}
        [Column(name:"EMAIL_EXIBE")]
        public string EmailExibe {get;set;}
        [Column(name:"NOME_EXIBE")]
        public string NomeExibe {get;set;}
        public string Assunto {get;set;}
        public string Descricao {get;set;}
        [Column(name:"ALTERAR_DADOS_EMAIL")]
        public string AlterarDadosEmail {get;set;}
    }
}