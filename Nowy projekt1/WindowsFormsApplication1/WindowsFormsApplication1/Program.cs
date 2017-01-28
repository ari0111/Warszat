using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            logowanie formularzLogowania = new logowanie();
            if (formularzLogowania.ShowDialog()==DialogResult.OK)
            {
                Application.Run(new Menu());
            }
        }
    }
}
