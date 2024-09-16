public class ContaCorrente
{
        private string numeroConta;
        private string titularConta;
        private decimal saldo;

        public string NumeroConta { get => numeroConta; set => numeroConta = value; }
        public string TitularConta { get => titularConta; set => titularConta = value; }
        public decimal Saldo { get => saldo; set => saldo = value; }

        public decimal mostrarSaldo() {
            return Saldo;
        }
        public void depositarSaldo(decimal valor) 
        {
            if (valor > 0)
            {
                Saldo += valor;
            }
            else
            {
                throw new ArgumentException("O valor do depósito deve ser positivo.");
            }
        }
        public void sacarSaldo(decimal valor) {
            if (valor < 0)
            {
                throw new ArgumentException("O valor do saque deve ser positivo.");
            }

            if (valor > Saldo)
            {
                throw new ArgumentException("O valor do saque deve ser menor que o saldo disponível.");
            }

            Saldo -= valor;
        }
}
