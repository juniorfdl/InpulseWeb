using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inpulse.Domain
{

    public class Campanhas: IEntidadeBase
    {   
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("CODIGO")] 
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime? DATA_INI { get; set; }
        public int? Max_Resposta { get; set; }
        public string Descricao { get; set; }
        public int? Prioridade { get; set; }
        public string Sql_Campanha { get; set; }
        public string Gerado_Lista { get; set; }
        public string Pausada { get; set; }
        public string Pausar_Ag_Publica { get; set; }
        public string Tipo { get; set; }
        public int? Unidade { get; set; }
        public int? Operador { get; set; }
    }

}