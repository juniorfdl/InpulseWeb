using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inpulse.Domain
{
    public class Operadores: IEntidadeBase
    {
        [Key]   
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("CODIGO")]      
        public int Id { get; set; }
        public string ATIVO { get; set; }
        public string NOME { get; set; }
        public string LOGIN { get; set; }
        public string EMAIL { get; set; }
        public string SENHA { get; set; }
        public DateTime? EXPIRA_EM { get; set; }
        public string NIVEL { get; set; }
        public int? HORARIO { get; set; }
        public string ALTERA_SENHA { get; set; }
        public string CODIGO_ERP { get; set; }
        public string EDITA_CONTATOS { get; set; }
        public string VISUALIZA_COMPRAS { get; set; }
        public string CADASTRO { get; set; }
        public DateTime? ULTIMO_LOGIN_INI { get; set; }
        public DateTime? ULTIMO_LOGIN_FIM { get; set; }
        public DateTime? DATACAD { get; set; }
        public string CODTELEFONIA { get; set; }
        public int? LOGADO { get; set; }
        public string AGENDA_LIG { get; set; }
        public string LIGA_REPRESENTANTE { get; set; }
        public string FILTRA_DDD { get; set; }
        public string FILTRA_ESTADO { get; set; }
        public string BANCO { get; set; }
        public string ASTERISK_RAMAL { get; set; }
        public string ASTERISK_USERID { get; set; }
        public string ASTERISK_LOGIN { get; set; }
        public string ASTERISK_SENHA { get; set; }
        public string CODEC { get; set; } 
    }
}