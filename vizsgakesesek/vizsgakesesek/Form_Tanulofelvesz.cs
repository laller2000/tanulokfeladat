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
    public partial class Form_Tanulofelvesz : Form
    {
        public Form_Tanulofelvesz()
        {
            InitializeComponent();
        }

        private void button1_Rogzit_Click(object sender, EventArgs e)
        {
            string vezeteknev=textBox1_Vezeteknev.Text.ToString();
            string keresztnev=textBox2_Keresztnev.Text.ToString();
            string osztaly = textBox4_Osztaly.Text.ToString();
            string ofoneve = textBox3_Ofo.Text.ToString();
            if (String.IsNullOrEmpty(vezeteknev))
            {
                MessageBox.Show("Nem töltötted ki a vezeteknev mezőt!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrEmpty(keresztnev))
            {
                MessageBox.Show("Nem töltötted ki a keresztnev mezőt!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrEmpty(osztaly))
            {
                MessageBox.Show("Nem töltötted ki a osztaly mezőt!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrEmpty(ofoneve))
            {
                MessageBox.Show("Nem töltötted ki az osztalyfonok mezőt!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                Program.sql.CommandText = "INSERT INTO `vizsga_tanulo`(`id`, `vezeteknev`, `keresztnev`, `osztaly`, `ofo_neve`) VALUES (NULL,'"+vezeteknev+"','"+keresztnev+"','"+osztaly+"','"+ofoneve+"')";
                Program.sql.ExecuteNonQuery();
            }
            catch (MySqlException myex)
            {
                MessageBox.Show(myex.Message);
                return;
            }
            MessageBox.Show("A rögzítés sikeres!");
            textBox1_Vezeteknev.Text = "";
            textBox2_Keresztnev.Text = "";
            textBox3_Ofo.Text = "";
            textBox4_Osztaly.Text = "";
            this.Hide();
            Program.form_tanulo.Show();
        }
    }
}
