using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inpulse.Domain
{

    public class Clientes: IEntidadeBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("CODIGO")] 
        public int Id { get; set; }
        public string Razao {get;set;}
        public string Fantasia {get;set;}
        [Column("CPF_CNPJ")] 
        public string CpfCnpj {get;set;}
        public string IE_RG {get;set;}
        public int? Grupo {get;set;}
        [Column("END_RUA")] 
        public string EndRua {get;set;}
        public string Cidade {get;set;}
        public string Bairro {get;set;}
        public string Estado {get;set;}
        public string Cep {get;set;}
        public string Complemento {get;set;}
        public int? Area1 {get;set;}
        public int? Area2 {get;set;}
        public int? Area3 {get;set;}
        public int? AreaFax {get;set;}
        public string Fone1 {get;set;}
        public string Fone2 {get;set;}
        public string Fone3 {get;set;}
        public string Fax {get;set;}
        [Column("DESC_FONE1")] 
        public string DescFone1 {get;set;}
        [Column("DESC_FONE2")] 
        public string DescFone2 {get;set;}
        [Column("DESC_FONE3")] 
        public string DescFone3 {get;set;}
        public string DescFax {get;set;}
        public string Email {get;set;}
        public string WebSite {get;set;}
        public DateTime? DataCad {get;set;}
        [Column("STATUS_CAD")] 
        public string StatusCad {get;set;}
        public int? Origem {get;set;}
        public int? Operador {get;set;}
        [Column("COD_MIDIA")] 
        public int? CodMidia {get;set;}
        [Column("COD_ERP")] 
        public string CodErp {get;set;}
        [Column("COD_UNIDADE")] 
        public int? CodUnidade {get;set;}
        [Column("SALDO_DISPONIVEL")] 
        public double? SaldoDisponivel {get;set;}
        [Column("SALDO_LIMITE")] 
        public double? SaldoLimite {get;set;}
        public double? Potencial {get;set;}
        [Column("DATA_ULT_COMPRA")] 
        public DateTime? DataUltCompra {get;set;}
        public int? Segmento {get;set;}
        [Column("ULTI_RESULTADO")] 
        public DateTime? UltiResultado {get;set;}
        [Column("DT_AGENDAMENTO")] 
        public DateTime? DtAgendamento {get;set;}
        [Column("COD_CAMPANHA")] 
        public int? CodCampanha {get;set;}
        [Column("COD_RESULTADO")] 
        public int? CodResultado {get;set;}
        [Column("CONTATO_MAIL")] 
        public string ContatoMail {get;set;}
        [Column("OPERADOR_LOGIN")] 
        public string OperadorLogin {get;set;}
        [Column("OBS_FONE1")]
        public string ObsFone1 {get;set;}
        [Column("OBS_FONE2")]
        public string ObsFone2 {get;set;}
        [Column("OBS_FONE3")]
        public string ObsFone3 {get;set;}
        public string Email2 {get;set;}
        [Column("NR_FUNCIONARIOS")]
        public int? NrFuncionarios {get;set;}
        [Column("OBS_CLIENTES")]
        public string ObsClientes {get;set;}
        [Column("VENCIMENTO_LIMITE_CREDITO")]
        public DateTime? VencimentoLimiteCredito {get;set;}
        [Column("PERIODO_RECOMPRA")]
        public int?PeriodoRecompra {get;set;}
        [Column(name:"OBS_ADMIN")]
        public string ObsAdmin { get; set; }
        [Column(name:"OBS_OPERADOR")]
        public string ObsOperador { get; set; }
    }

}