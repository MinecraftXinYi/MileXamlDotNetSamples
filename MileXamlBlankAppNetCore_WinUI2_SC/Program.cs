using System;
using System.Windows.Forms;
using WinRT;

namespace MileXamlBlankAppNetCore
{
    public static class Program
    {
        public static Form MainForm { get; private set; }

        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ComWrappersSupport.InitializeComWrappers();

            App app = new();

            MainForm = new Form1();
            Application.Run(MainForm);

            app.Close();
        }
    }
}
