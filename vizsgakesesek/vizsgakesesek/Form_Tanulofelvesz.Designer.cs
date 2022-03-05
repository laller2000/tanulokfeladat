
namespace vizsgakesesek
{
    partial class Form_Tanulofelvesz
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1_Rogzit = new System.Windows.Forms.Button();
            this.textBox1_Vezeteknev = new System.Windows.Forms.TextBox();
            this.textBox2_Keresztnev = new System.Windows.Forms.TextBox();
            this.textBox3_Ofo = new System.Windows.Forms.TextBox();
            this.textBox4_Osztaly = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vezeteknev:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Keresztnev:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(134, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Osztály:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(134, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ofő_neve:";
            // 
            // button1_Rogzit
            // 
            this.button1_Rogzit.Location = new System.Drawing.Point(354, 347);
            this.button1_Rogzit.Name = "button1_Rogzit";
            this.button1_Rogzit.Size = new System.Drawing.Size(88, 55);
            this.button1_Rogzit.TabIndex = 4;
            this.button1_Rogzit.Text = "Rögzítés";
            this.button1_Rogzit.UseVisualStyleBackColor = true;
            this.button1_Rogzit.Click += new System.EventHandler(this.button1_Rogzit_Click);
            // 
            // textBox1_Vezeteknev
            // 
            this.textBox1_Vezeteknev.Location = new System.Drawing.Point(273, 41);
            this.textBox1_Vezeteknev.Name = "textBox1_Vezeteknev";
            this.textBox1_Vezeteknev.Size = new System.Drawing.Size(392, 22);
            this.textBox1_Vezeteknev.TabIndex = 5;
            // 
            // textBox2_Keresztnev
            // 
            this.textBox2_Keresztnev.Location = new System.Drawing.Point(273, 113);
            this.textBox2_Keresztnev.Name = "textBox2_Keresztnev";
            this.textBox2_Keresztnev.Size = new System.Drawing.Size(392, 22);
            this.textBox2_Keresztnev.TabIndex = 6;
            // 
            // textBox3_Ofo
            // 
            this.textBox3_Ofo.Location = new System.Drawing.Point(248, 262);
            this.textBox3_Ofo.Name = "textBox3_Ofo";
            this.textBox3_Ofo.Size = new System.Drawing.Size(392, 22);
            this.textBox3_Ofo.TabIndex = 7;
            // 
            // textBox4_Osztaly
            // 
            this.textBox4_Osztaly.Location = new System.Drawing.Point(258, 198);
            this.textBox4_Osztaly.Name = "textBox4_Osztaly";
            this.textBox4_Osztaly.Size = new System.Drawing.Size(392, 22);
            this.textBox4_Osztaly.TabIndex = 8;
            // 
            // Form_Tanulofelvesz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox4_Osztaly);
            this.Controls.Add(this.textBox3_Ofo);
            this.Controls.Add(this.textBox2_Keresztnev);
            this.Controls.Add(this.textBox1_Vezeteknev);
            this.Controls.Add(this.button1_Rogzit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_Tanulofelvesz";
            this.Text = "Form_Tanulofelvesz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1_Rogzit;
        private System.Windows.Forms.TextBox textBox1_Vezeteknev;
        private System.Windows.Forms.TextBox textBox2_Keresztnev;
        private System.Windows.Forms.TextBox textBox3_Ofo;
        private System.Windows.Forms.TextBox textBox4_Osztaly;
    }
}