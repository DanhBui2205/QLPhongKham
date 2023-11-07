using Quanlikho.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quanlikho.Utils;
using Quanlikho.Views;

namespace Quanlikho
{
    internal static class PROGRAM
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Datahelper.dbName = "qlphongkham";
            Datahelper.serverName = "localhost";
            Datahelper.userDb = "sa";
            Datahelper.password = "123";
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }
    }
}
