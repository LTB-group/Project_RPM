using System;
using System.Windows.Forms;

namespace Project_
{
    internal static class Program
    {
        /// <summary>
        /// Точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new log_in(0)); // Значение по умолчанию для userId
        }
    }
}
