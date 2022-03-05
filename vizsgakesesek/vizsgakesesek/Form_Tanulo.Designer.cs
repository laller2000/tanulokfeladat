
namespace vizsgakesesek
{
    partial class Form_Tanulo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1_Tanulok = new System.Windows.Forms.DataGridView();
            this.button1_UJdiak = new System.Windows.Forms.Button();
            this.button2_Adatokfrissites = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_Tanulok)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tanulók késéseinek nyilvántartása";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "A nyilvántartásban szereplő tanulók adatai:";
            // 
            // dataGridView1_Tanulok
            // 
            this.dataGridView1_Tanulok.AllowUserToAddRows = false;
            this.dataGridView1_Tanulok.AllowUserToDeleteRows = false;
            this.dataGridView1_Tanulok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1_Tanulok.Location = new System.Drawing.Point(75, 140);
            this.dataGridView1_Tanulok.Name = "dataGridView1_Tanulok";
            this.dataGridView1_Tanulok.ReadOnly = true;
            this.dataGridView1_Tanulok.RowHeadersWidth = 51;
            this.dataGridView1_Tanulok.RowTemplate.Height = 24;
            this.dataGridView1_Tanulok.Size = new System.Drawing.Size(672, 210);
            this.dataGridView1_Tanulok.TabIndex = 2;
            this.dataGridView1_Tanulok.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_Tanulok_CellContentClick);
            // 
            // button1_UJdiak
            // 
            this.button1_UJdiak.Location = new System.Drawing.Point(111, 398);
            this.button1_UJdiak.Name = "button1_UJdiak";
            this.button1_UJdiak.Size = new System.Drawing.Size(143, 23);
            this.button1_UJdiak.TabIndex = 3;
            this.button1_UJdiak.Text = "Új diák felvétele";
            this.button1_UJdiak.UseVisualStyleBackColor = true;
            this.button1_UJdiak.Click += new System.EventHandler(this.button1_UJdiak_Click);
            // 
            // button2_Adatokfrissites
            // 
            this.button2_Adatokfrissites.Location = new System.Drawing.Point(512, 397);
            this.button2_Adatokfrissites.Name = "button2_Adatokfrissites";
            this.button2_Adatokfrissites.Size = new System.Drawing.Size(141, 23);
            this.button2_Adatokfrissites.TabIndex = 4;
            this.button2_Adatokfrissites.Text = "Adatok frissítése";
            this.button2_Adatokfrissites.UseVisualStyleBackColor = true;
            this.button2_Adatokfrissites.Click += new System.EventHandler(this.button2_Adatokfrissites_Click);
            // 
            // Form_Tanulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2_Adatokfrissites);
            this.Controls.Add(this.button1_UJdiak);
            this.Controls.Add(this.dataGridView1_Tanulok);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_Tanulo";
            this.Text = "Tanulok";
            this.Load += new System.EventHandler(this.Form_Tanulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_Tanulok)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1_Tanulok;
        private System.Windows.Forms.Button button1_UJdiak;
        private System.Windows.Forms.Button button2_Adatokfrissites;
    }
}

