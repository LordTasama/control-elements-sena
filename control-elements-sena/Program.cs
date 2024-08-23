using System;
using System.Windows.Forms;

namespace control_elements_sena
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Login login = new Login();

            if (login.ShowDialog() == DialogResult.OK) { 
            Application.Run(new ControlPanel());
            }

        }
    }
}
