using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AulaHeranca
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            

            ContaEspecial conta = new ContaEspecial("222245", "Nezuko", 1000.00m, 3000.00m);
            Application.Run(new Form1(conta));
        }
    }
}
