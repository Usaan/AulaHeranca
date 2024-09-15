using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AulaHeranca
{
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
        public void depositarSaldo() { }
        public void sacarSaldo() { }
    }
}
