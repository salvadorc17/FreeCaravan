using System;
using System.Windows.Forms;
using IrrKlang;

namespace FreeCaravan
{
    static class Program
    {
        [STAThread]
        static void Main()
        {

            

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }
    }
}
