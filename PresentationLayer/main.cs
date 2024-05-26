using System;
using System.Windows.Forms;

namespace PresentationLayer
{
    static class main
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Caratula());
        }
    }
}