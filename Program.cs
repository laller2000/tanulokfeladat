using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace vizsgakesesek
{
    static class Program
    {
        public static MySqlCommand sql = null;
        public static MySqlConnection conn = null;
        public static Form form_tanulo = null;
        public static Form form_tanulofelvesz = null;
        public static Form form_kesesek = null;
        [STAThread]
        static void Main()
        {
            MySqlConnectionStringBuilder sb = new MySqlConnectionStringBuilder();
            sb.Server = "localhost";
            sb.UserID = "root";
            sb.Password = "";
            sb.Database = "tanulok";
            conn = new MySqlConnection(sb.ToString());
            try
            {
                conn.Open();
                sql = conn.CreateCommand();
            }
            catch (MySqlException myex)
            {
                Console.WriteLine(myex.Message);
                Console.ReadKey();
                Environment.Exit(0);
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            form_tanulo = new Form_Tanulo();
            form_kesesek = new Form_Kesesek();
            form_tanulofelvesz = new Form_Tanulofelvesz();
            Application.Run(form_tanulo);
        }
    }
}
