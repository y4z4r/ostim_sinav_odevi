namespace TriviaGrupÖdev
{
    partial class Form1
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
            this.panel_bilgi = new System.Windows.Forms.Panel();
            this.label_bilgi = new System.Windows.Forms.Label();
            this.panel_cevaplar = new System.Windows.Forms.Panel();
            this.groupBox_cvp = new System.Windows.Forms.GroupBox();
            this.button_d = new System.Windows.Forms.Button();
            this.button_b = new System.Windows.Forms.Button();
            this.button_c = new System.Windows.Forms.Button();
            this.button_a = new System.Windows.Forms.Button();
            this.button_onay = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_sure = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_puan = new System.Windows.Forms.Label();
            this.panel_bilgi.SuspendLayout();
            this.panel_cevaplar.SuspendLayout();
            this.groupBox_cvp.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_bilgi
            // 
            this.panel_bilgi.BackColor = System.Drawing.SystemColors.Info;
            this.panel_bilgi.Controls.Add(this.label_bilgi);
            this.panel_bilgi.Location = new System.Drawing.Point(47, 12);
            this.panel_bilgi.Name = "panel_bilgi";
            this.panel_bilgi.Size = new System.Drawing.Size(600, 100);
            this.panel_bilgi.TabIndex = 0;
            // 
            // label_bilgi
            // 
            this.label_bilgi.AutoSize = true;
            this.label_bilgi.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_bilgi.Location = new System.Drawing.Point(22, 9);
            this.label_bilgi.Name = "label_bilgi";
            this.label_bilgi.Size = new System.Drawing.Size(558, 81);
            this.label_bilgi.TabIndex = 0;
            this.label_bilgi.Text = "\r\nBU BİR TRIVIA OYUNUDUR PROGRAMLAMAYLA ILGILI\r\n                             BILG" +
    "INIZI OLCER.";
            // 
            // panel_cevaplar
            // 
            this.panel_cevaplar.BackColor = System.Drawing.Color.LightCyan;
            this.panel_cevaplar.Controls.Add(this.groupBox_cvp);
            this.panel_cevaplar.Location = new System.Drawing.Point(12, 130);
            this.panel_cevaplar.Name = "panel_cevaplar";
            this.panel_cevaplar.Size = new System.Drawing.Size(660, 181);
            this.panel_cevaplar.TabIndex = 1;
            // 
            // groupBox_cvp
            // 
            this.groupBox_cvp.Controls.Add(this.button_d);
            this.groupBox_cvp.Controls.Add(this.button_b);
            this.groupBox_cvp.Controls.Add(this.button_c);
            this.groupBox_cvp.Controls.Add(this.button_a);
            this.groupBox_cvp.Location = new System.Drawing.Point(0, 0);
            this.groupBox_cvp.Name = "groupBox_cvp";
            this.groupBox_cvp.Size = new System.Drawing.Size(660, 191);
            this.groupBox_cvp.TabIndex = 0;
            this.groupBox_cvp.TabStop = false;
            this.groupBox_cvp.Text = "Cevaplar";
            // 
            // button_d
            // 
            this.button_d.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_d.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_d.Location = new System.Drawing.Point(362, 119);
            this.button_d.Name = "button_d";
            this.button_d.Size = new System.Drawing.Size(138, 37);
            this.button_d.TabIndex = 3;
            this.button_d.Text = "Bilgisayar Prog ";
            this.button_d.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_d.UseVisualStyleBackColor = true;
            // 
            // button_b
            // 
            this.button_b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_b.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_b.Location = new System.Drawing.Point(362, 19);
            this.button_b.Name = "button_b";
            this.button_b.Size = new System.Drawing.Size(83, 37);
            this.button_b.TabIndex = 2;
            this.button_b.Text = "TEKNİK";
            this.button_b.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_b.UseVisualStyleBackColor = true;
            // 
            // button_c
            // 
            this.button_c.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_c.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_c.Location = new System.Drawing.Point(35, 120);
            this.button_c.Name = "button_c";
            this.button_c.Size = new System.Drawing.Size(115, 37);
            this.button_c.TabIndex = 1;
            this.button_c.Text = "Üniversitesi";
            this.button_c.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_c.UseVisualStyleBackColor = true;
            // 
            // button_a
            // 
            this.button_a.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_a.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_a.Location = new System.Drawing.Point(35, 19);
            this.button_a.Name = "button_a";
            this.button_a.Size = new System.Drawing.Size(78, 37);
            this.button_a.TabIndex = 0;
            this.button_a.Text = "OSTİM";
            this.button_a.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_a.UseVisualStyleBackColor = true;
            // 
            // button_onay
            // 
            this.button_onay.BackColor = System.Drawing.Color.SkyBlue;
            this.button_onay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_onay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_onay.Location = new System.Drawing.Point(190, 317);
            this.button_onay.Name = "button_onay";
            this.button_onay.Size = new System.Drawing.Size(300, 50);
            this.button_onay.TabIndex = 2;
            this.button_onay.Text = "Cevabı Onayla";
            this.button_onay.UseVisualStyleBackColor = false;
            this.button_onay.Click += new System.EventHandler(this.button_onay_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCoral;
            this.panel1.Controls.Add(this.label_sure);
            this.panel1.Location = new System.Drawing.Point(12, 409);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 40);
            this.panel1.TabIndex = 3;
            // 
            // label_sure
            // 
            this.label_sure.AutoSize = true;
            this.label_sure.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_sure.Location = new System.Drawing.Point(31, 9);
            this.label_sure.Name = "label_sure";
            this.label_sure.Size = new System.Drawing.Size(91, 21);
            this.label_sure.TabIndex = 0;
            this.label_sure.Text = "Kalan Sure";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Chartreuse;
            this.panel2.Controls.Add(this.label_puan);
            this.panel2.Location = new System.Drawing.Point(522, 409);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(150, 40);
            this.panel2.TabIndex = 4;
            // 
            // label_puan
            // 
            this.label_puan.AutoSize = true;
            this.label_puan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_puan.Location = new System.Drawing.Point(38, 9);
            this.label_puan.Name = "label_puan";
            this.label_puan.Size = new System.Drawing.Size(77, 21);
            this.label_puan.TabIndex = 0;
            this.label_puan.Text = "Puaniniz";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_onay);
            this.Controls.Add(this.panel_cevaplar);
            this.Controls.Add(this.panel_bilgi);
            this.MaximumSize = new System.Drawing.Size(700, 500);
            this.MinimumSize = new System.Drawing.Size(700, 500);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel_bilgi.ResumeLayout(false);
            this.panel_bilgi.PerformLayout();
            this.panel_cevaplar.ResumeLayout(false);
            this.groupBox_cvp.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_bilgi;
        private System.Windows.Forms.Label label_bilgi;
        private System.Windows.Forms.Panel panel_cevaplar;
        private System.Windows.Forms.GroupBox groupBox_cvp;
        private System.Windows.Forms.Button button_d;
        private System.Windows.Forms.Button button_b;
        private System.Windows.Forms.Button button_c;
        private System.Windows.Forms.Button button_a;
        private System.Windows.Forms.Button button_onay;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_sure;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label_puan;
    }
}

