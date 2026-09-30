using miPrimeaAplicacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miPrimeAplicacion
{
    internal static class Program
    {
        /// 
        /// Punto de entrada principal para la aplicación.
        /// 
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Inicia la aplicación con el menú principal MDI
            Application.Run(new frmPrincipal());
        }
    }
}