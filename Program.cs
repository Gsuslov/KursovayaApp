using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp2
{
    static class Program
    {
        public static string runDir = Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory);
        public static string filePath = Directory.GetParent(Directory.GetParent(runDir).FullName).FullName;
        public static string ConnectionString = String.Format(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Георгий\Desktop\KursovayaApp\Database1.mdf;Integrated Security=True", filePath);
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {          
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }
    }
}
