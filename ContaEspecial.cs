using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaHeranca
{
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

        public decimal DiminuiLimite(decimal _valor)
        {
             decimal novolimite = limite - _valor;
            
           return novolimite;

        }

        public decimal AumentaLimite(decimal _valor)
        {
            decimal novolimite = limite + _valor;

            return novolimite;

        }
    }
}
