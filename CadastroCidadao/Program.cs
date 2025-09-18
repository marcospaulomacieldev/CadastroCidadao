using System;
using System.Windows.Forms;
using CadastroCidadao.UI;

namespace CadastroCidadao
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }
    }
}
