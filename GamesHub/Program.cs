using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GamesHub
{
    public static class Program
    {

        public static string path { get; set; }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //check some stuff in documents, make sure it's there.
            path = "";


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            while (String.IsNullOrEmpty(path))
            {
                Application.Run(new SelectRootScreen());
            }


            if (!String.IsNullOrEmpty(path))
            {
                Application.Run(new GamesHubMain(path));
            }

            Console.WriteLine("DOne");
        }
    }
}
