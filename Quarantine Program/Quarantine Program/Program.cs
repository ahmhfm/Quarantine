using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Quarantine_Program
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        public static DataTable userDt;
        public static DataTable Almantiq;
        public static DataTable city;
        public static DataTable Quarry;
        public static DataTable Room;


        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new frm_users());
            Application.Run(new Form1());
        }
    }
}
