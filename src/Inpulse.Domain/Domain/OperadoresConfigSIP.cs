using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inpulse.Domain
{

    [Table("operadores_config_sip")]
    public class OperadoresConfigSIP: IEntidadeBase
    {    
        
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("COD_CONFIG_SIP")] 
        public int Id { get; set; }
        public int Cod_Operador { get; set; }
        [Column("RAMAL_SIP")]
        public string Ramal_SIP { get; set; }
        [Column("IP_SERVIDOR_SIP")]
        public string IpServidorSip {get;set;}
        [Column("LOGIN_SIP")]
        public string LoginSip {get;set;}
        [Column("SENHA_SIP")]
        public string SenhaSip {get;set;}
        [Column("USRID_SIP")]
        public string UsrIdSip {get;set;}
        [Column("CODECS_SIP")]
        public string CodecsSip {get;set;}
        [Column("CFG_CONFIG_SIP")]
        public string CfgConfigSip {get;set;}
    }

}