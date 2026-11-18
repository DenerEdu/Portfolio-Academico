using ProjetoHortiFruti.Views;
using System;
using System.Windows.Forms;

namespace ProjetoHortiFruti
{
    internal static class Program
    {
        /// 
        /// Ponto de entrada principal para o aplicativo.
        /// 
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmPrincipal());
        }
    }
}
