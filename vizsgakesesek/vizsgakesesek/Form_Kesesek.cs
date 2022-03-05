using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace vizsgakesesek
{
    public partial class Form_Kesesek : Form
    {
        List<Vizsga_Keses> kesesek = new List<Vizsga_Keses>();
        public int osszeske = 0;
        public string valasz = "";
        public Form_Kesesek()
        {
            InitializeComponent();
        }

        private void Form_Kesesek_Load(object sender, EventArgs e)
        {
            dataGridView1_Kesesek.ColumnCount = 3;
            dataGridView1_Kesesek.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1_Kesesek.Columns[0].Name = "mikor";
            dataGridView1_Kesesek.Columns[0].HeaderText = "Késés dátuma";
            dataGridView1_Kesesek.Columns[1].Name = "igazolt";
            dataGridView1_Kesesek.Columns[1].HeaderText = "Igazolt-e a késés";
            dataGridView1_Kesesek.Columns[2].Name = "megjegyzes";
            dataGridView1_Kesesek.Columns[2].HeaderText = "Megjegyzés";

            try
            {
                Program.sql.CommandText = "SELECT  `mikor`, `igazolt`, `megjegyzes` FROM `vizsga_keses` WHERE 1";
                using (MySqlDataReader dr=Program.sql.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        int uj_sor_indexe = dataGridView1_Kesesek.Rows.Add();
                        DataGridViewRow ujsor = dataGridView1_Kesesek.Rows
                            [uj_sor_indexe];
                        ujsor.Cells["mikor"].Value = dr.GetDateTime("mikor");
                        ujsor.Cells["igazolt"].Value = dr.GetString("igazolt");
                        ujsor.Cells["megjegyzes"].Value = dr.GetString("megjegyzes");
                    }
                }
            }
            catch (MySqlException myex)
            {
                MessageBox.Show(myex.Message);
                return;
            }
            KesesekListafeltoltese();
            for (int i = 0; i < kesesek.Count; i++)
            {
                if (kesesek[i].Igazolt.Equals("nem"))
                {
                    valasz = "nem";
                    osszeske++;
                }
            }
            textBox1_Osszes.Text = osszeske.ToString();
            if (osszeske>10)
            {
                textBox2_Keses10.Text = "igen";
            }
            else
            {
                textBox2_Keses10.Text = "nem";
            }
            
        }
        private void KesesekListafeltoltese()
        {
            kesesek.Clear();
            try
            {
                Program.sql.CommandText = "SELECT `id`, `tanuloID`, `mikor`, `igazolt`, `megjegyzes` FROM `vizsga_keses` WHERE 1";
                using (MySqlDataReader dr=Program.sql.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        kesesek.Add(new Vizsga_Keses(dr.GetInt32("id"),dr.GetInt32("tanuloID"),dr.GetDateTime("mikor"),dr.GetString("igazolt"),dr.GetString("megjegyzes")));
                    }
                }
            }
            catch (MySqlException myex)
            {
                MessageBox.Show(myex.Message);
                return;
            }
        }
    }
}
