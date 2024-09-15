using Bunifu.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AulaHeranca
{
    public partial class Form1 : Form
    {
        private ContaEspecial conta;
        public Form1(ContaEspecial contaEspecial)
        {
            InitializeComponent();
            conta = contaEspecial;
            username.Text = $"Olá, {conta.TitularConta}!";
            lbSaldo.Text = $"R${conta.mostrarSaldo():F2}";
            lbLimite.Text = $"R${conta.ConsultaLimite():F2}";
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Seu limite atual é de: R${conta.ConsultaLimite()}");
        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void AtualizarSaldo()
        {
            lbSaldo.Text = $"Saldo: R${conta.Saldo:F2}";
        }

        private void lbSaldo_Click(object sender, EventArgs e)
        {
            
        }

        private void lbSaldo_Layout(object sender, LayoutEventArgs e)
        {

        }

        private void bunifuLabel2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel2_Click_1(object sender, EventArgs e)
        {

        }

        private void Depositar_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Quanto deseja depositar?");
            // vai ter q criar outro form q tenha um TextBox pra receber o input e um botão pra confirmar
            // daí é só chamar esse form como se fosse um método
        }
    }
}
