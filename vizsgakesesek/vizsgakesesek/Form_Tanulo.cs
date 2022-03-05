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
    public partial class Form_Tanulo : Form
    {
        public Form_Tanulo()
        {
            InitializeComponent();
        }

        private void Form_Tanulo_Load(object sender, EventArgs e)
        {
            dataGridView1_Tanulok.ColumnCount = 5;
            dataGridView1_Tanulok.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1_Tanulok.Columns[0].Name = "id";
            dataGridView1_Tanulok.Columns[0].HeaderText = "Azonosító";
            dataGridView1_Tanulok.Columns[1].Name = "vezeteknev";
            dataGridView1_Tanulok.Columns[1].HeaderText = "Vezetéknév";
            dataGridView1_Tanulok.Columns[2].Name = "keresztnev";
            dataGridView1_Tanulok.Columns[2].HeaderText = "keresztnev";
            dataGridView1_Tanulok.Columns[3].Name = "osztaly";
            dataGridView1_Tanulok.Columns[3].HeaderText = "Osztály";
            dataGridView1_Tanulok.Columns[4].Name = "ofo_neve";
            dataGridView1_Tanulok.Columns[4].HeaderText = "Osztály főnök neve";

            try
            {
                Program.sql.CommandText = "SELECT `id`, `vezeteknev`, `keresztnev`, `osztaly`, `ofo_neve` FROM `vizsga_tanulo` WHERE 1";
                using (MySqlDataReader dr=Program.sql.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        int ujsorindex = dataGridView1_Tanulok.Rows.Add();
                        DataGridViewRow ujsor = dataGridView1_Tanulok.Rows
                            [ujsorindex];
                        ujsor.Cells["id"].Value = dr.GetInt32("id");
                        ujsor.Cells["vezeteknev"].Value = dr.GetString("vezeteknev");
                        ujsor.Cells["keresztnev"].Value = dr.GetString("keresztnev");
                        ujsor.Cells["osztaly"].Value = dr.GetString("osztaly");
                        ujsor.Cells["ofo_neve"].Value = dr.GetString("ofo_neve");
                    }
                }
            }
            catch (MySqlException myex)
            {
                MessageBox.Show("Hiba történt!" + myex.Message);
                return;
            }
        }

        private void button1_UJdiak_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.form_tanulofelvesz.Show();
        }

        private void button2_Adatokfrissites_Click(object sender, EventArgs e)
        {
            dataGridView1_Tanulok.ColumnCount = 5;
            dataGridView1_Tanulok.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1_Tanulok.Columns[0].Name = "id";
            dataGridView1_Tanulok.Columns[0].HeaderText = "Azonosító";
            dataGridView1_Tanulok.Columns[1].Name = "vezeteknev";
            dataGridView1_Tanulok.Columns[1].HeaderText = "Vezetéknév";
            dataGridView1_Tanulok.Columns[2].Name = "keresztnev";
            dataGridView1_Tanulok.Columns[2].HeaderText = "keresztnev";
            dataGridView1_Tanulok.Columns[3].Name = "osztaly";
            dataGridView1_Tanulok.Columns[3].HeaderText = "Osztály";
            dataGridView1_Tanulok.Columns[4].Name = "ofo_neve";
            dataGridView1_Tanulok.Columns[4].HeaderText = "Osztály főnök neve";

            try
            {
                Program.sql.CommandText = "SELECT `id`, `vezeteknev`, `keresztnev`, `osztaly`, `ofo_neve` FROM `vizsga_tanulo` WHERE 1";
                using (MySqlDataReader dr = Program.sql.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        int ujsorindex = dataGridView1_Tanulok.Rows.Add();
                        DataGridViewRow ujsor = dataGridView1_Tanulok.Rows
                            [ujsorindex];
                        ujsor.Cells["id"].Value = dr.GetInt32("id");
                        ujsor.Cells["vezeteknev"].Value = dr.GetString("vezeteknev");
                        ujsor.Cells["keresztnev"].Value = dr.GetString("keresztnev");
                        ujsor.Cells["osztaly"].Value = dr.GetString("osztaly");
                        ujsor.Cells["ofo_neve"].Value = dr.GetString("ofo_neve");
                    }
                }
            }
            catch (MySqlException myex)
            {
                MessageBox.Show("Hiba történt!" + myex.Message);
                return;
            }
        }

        private void dataGridView1_Tanulok_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Hide();
            Program.form_kesesek.Show();
        }
    }
}
