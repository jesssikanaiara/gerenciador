namespace GerenciadorApi.Models
{
    public class TipoFormaPagamento
    {
        public const string Dinheiro = "01";
        public const string Cheque = "02";
        public const string CartaoCredito = "03";
        public const string CartaoDebito = "04";
        public const string CreditoLoja = "05";
        public const string ValeAlimentacao = "10";
        public const string ValeRefeicao = "11";
        public const string ValePresente = "12";
        public const string ValeCombustivel = "13";
        public const string Outros = "99";       
    }
    
    public class TipoBandeiraCartao
    {
        public const string Visa = "01";  
        public const string Mastercard = "02";  
        public const string AmericaExpress = "03";  
        public const string Sorocred = "04";  
        public const string Outros = "99";  
    }
}