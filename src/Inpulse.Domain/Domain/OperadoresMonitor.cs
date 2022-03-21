using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inpulse.Domain
{

    [Table("operadores_monitor")]
    public class OperadoresMonitor: IEntidadeBase
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("USUARIO")] 
        public int Id { get; set; }
        public int Id_DB { get; set; }
        public DateTime DataHora_Login { get; set; }
        public string Tipo_Conexao { get; set; }
        public string Acao { get; set; }
        public string IP { get; set; }
    }

}