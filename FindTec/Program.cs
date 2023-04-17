using System;
using System.Windows.Forms;

namespace FindTec
{
    static class Program
    {
        public static int id = 1;
        
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            TelaCadastro cadastro = new TelaCadastro();
            
            cadastro.AcessarAdmin();           
            Application.Run(new TelaLogin());
            
        }
    }
}
