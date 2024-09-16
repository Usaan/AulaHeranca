public class ContaEspecial : ContaCorrente
{
        private decimal limite;

        public decimal Limite { get => limite; set => limite = value; }

        public ContaEspecial(string _numero, string _titular, decimal _saldo, decimal _limite)
        {
            this.NumeroConta = _numero;
            this.TitularConta = _titular;
            this.Saldo = _saldo;
            this.Limite = _limite;
        }

        public decimal ConsultaLimite()
        {
            return Limite;
        }

        public void DiminuiLimite(decimal _valor)
        {
            Limite -= _valor;
        }

        public void AumentaLimite(decimal _valor)
        {
            Limite += _valor;
        }
}
