using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using eViewer.Forms;

namespace eViewer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DevExpress.Skins.SkinManager.EnableFormSkins();

            System.Threading.Thread.CurrentThread.CurrentUICulture =
                new System.Globalization.CultureInfo("pt-BR");

            System.Threading.Thread.CurrentThread.CurrentCulture =
                new System.Globalization.CultureInfo("pt-BR");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
            Application.Exit();
        }
    }
}
