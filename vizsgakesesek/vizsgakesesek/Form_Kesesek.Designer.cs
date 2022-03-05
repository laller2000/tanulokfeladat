
namespace vizsgakesesek
{
    partial class Form_Kesesek
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
            this.dataGridView1_Kesesek = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1_Osszes = new System.Windows.Forms.TextBox();
            this.textBox2_Keses10 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_Kesesek)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(334, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "A kiválasztott tanuló késései:";
            // 
            // dataGridView1_Kesesek
            // 
            this.dataGridView1_Kesesek.AllowUserToAddRows = false;
            this.dataGridView1_Kesesek.AllowUserToDeleteRows = false;
            this.dataGridView1_Kesesek.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1_Kesesek.Location = new System.Drawing.Point(74, 111);
            this.dataGridView1_Kesesek.Name = "dataGridView1_Kesesek";
            this.dataGridView1_Kesesek.ReadOnly = true;
            this.dataGridView1_Kesesek.RowHeadersWidth = 51;
            this.dataGridView1_Kesesek.RowTemplate.Height = 24;
            this.dataGridView1_Kesesek.Size = new System.Drawing.Size(665, 238);
            this.dataGridView1_Kesesek.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(294, 378);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "A tanuló összes késése:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(297, 421);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Elérte-e a 10 késést ?";
            // 
            // textBox1_Osszes
            // 
            this.textBox1_Osszes.Location = new System.Drawing.Point(473, 378);
            this.textBox1_Osszes.Name = "textBox1_Osszes";
            this.textBox1_Osszes.Size = new System.Drawing.Size(100, 22);
            this.textBox1_Osszes.TabIndex = 4;
            // 
            // textBox2_Keses10
            // 
            this.textBox2_Keses10.Location = new System.Drawing.Point(473, 421);
            this.textBox2_Keses10.Name = "textBox2_Keses10";
            this.textBox2_Keses10.Size = new System.Drawing.Size(100, 22);
            this.textBox2_Keses10.TabIndex = 5;
            // 
            // Form_Kesesek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 474);
            this.Controls.Add(this.textBox2_Keses10);
            this.Controls.Add(this.textBox1_Osszes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1_Kesesek);
            this.Controls.Add(this.label1);
            this.Name = "Form_Kesesek";
            this.Text = "Form_Kesesek";
            this.Load += new System.EventHandler(this.Form_Kesesek_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_Kesesek)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1_Kesesek;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1_Osszes;
        private System.Windows.Forms.TextBox textBox2_Keses10;
    }
}