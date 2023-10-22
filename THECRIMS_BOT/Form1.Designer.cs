namespace THECRIMS_BOT
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.button_login = new System.Windows.Forms.Button();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_pw = new System.Windows.Forms.TextBox();
            this.listBox_soygun_listesi = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_soygun_yap = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label_stamina = new System.Windows.Forms.Label();
            this.label_hp = new System.Windows.Forms.Label();
            this.label_bagimlilik = new System.Windows.Forms.Label();
            this.label_soygun_gucu = new System.Windows.Forms.Label();
            this.label_para = new System.Windows.Forms.Label();
            this.label_tolerans = new System.Windows.Forms.Label();
            this.label_karizma = new System.Windows.Forms.Label();
            this.label_str = new System.Windows.Forms.Label();
            this.label_int = new System.Windows.Forms.Label();
            this.button_bara_git = new System.Windows.Forms.Button();
            this.button_kontakt_detektor = new System.Windows.Forms.Button();
            this.checkBox_acil_cikis = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.button_unhide_hide_browser = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(804, 448);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Gray;
            this.tabPage1.Controls.Add(this.button_unhide_hide_browser);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.checkBox_acil_cikis);
            this.tabPage1.Controls.Add(this.button_kontakt_detektor);
            this.tabPage1.Controls.Add(this.button_bara_git);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.button_soygun_yap);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.listBox_soygun_listesi);
            this.tabPage1.Controls.Add(this.textBox_pw);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.checkBox1);
            this.tabPage1.Controls.Add(this.textBox_id);
            this.tabPage1.Controls.Add(this.button_login);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(796, 422);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Manuel Control";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(796, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Otomatik Kontrol";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(796, 424);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // button_login
            // 
            this.button_login.Location = new System.Drawing.Point(12, 87);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(75, 23);
            this.button_login.TabIndex = 1;
            this.button_login.Text = "Giriş";
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(79, 29);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(100, 20);
            this.textBox_id.TabIndex = 2;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(99, 91);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Beni Hatırla";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Şifre :";
            // 
            // textBox_pw
            // 
            this.textBox_pw.Location = new System.Drawing.Point(79, 61);
            this.textBox_pw.Name = "textBox_pw";
            this.textBox_pw.Size = new System.Drawing.Size(100, 20);
            this.textBox_pw.TabIndex = 5;
            // 
            // listBox_soygun_listesi
            // 
            this.listBox_soygun_listesi.FormattingEnabled = true;
            this.listBox_soygun_listesi.Location = new System.Drawing.Point(411, 29);
            this.listBox_soygun_listesi.Name = "listBox_soygun_listesi";
            this.listBox_soygun_listesi.Size = new System.Drawing.Size(212, 355);
            this.listBox_soygun_listesi.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(448, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Soygun Listesi";
            // 
            // button_soygun_yap
            // 
            this.button_soygun_yap.Enabled = false;
            this.button_soygun_yap.Location = new System.Drawing.Point(411, 390);
            this.button_soygun_yap.Name = "button_soygun_yap";
            this.button_soygun_yap.Size = new System.Drawing.Size(212, 23);
            this.button_soygun_yap.TabIndex = 8;
            this.button_soygun_yap.Text = "ONU SOY!";
            this.button_soygun_yap.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Stamina :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightBlue;
            this.groupBox1.Controls.Add(this.label_soygun_gucu);
            this.groupBox1.Controls.Add(this.label_para);
            this.groupBox1.Controls.Add(this.label_tolerans);
            this.groupBox1.Controls.Add(this.label_karizma);
            this.groupBox1.Controls.Add(this.label_str);
            this.groupBox1.Controls.Add(this.label_int);
            this.groupBox1.Controls.Add(this.label_bagimlilik);
            this.groupBox1.Controls.Add(this.label_hp);
            this.groupBox1.Controls.Add(this.label_stamina);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(629, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(161, 171);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Statlar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "HP         :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Bağımlılık:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(118, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Güç";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Zeka";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Karizma";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 145);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Soygun Gücü :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 132);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Para              :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(109, 97);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 13);
            this.label12.TabIndex = 15;
            this.label12.Text = "Tolerans";
            // 
            // label_stamina
            // 
            this.label_stamina.AutoSize = true;
            this.label_stamina.Location = new System.Drawing.Point(63, 16);
            this.label_stamina.Name = "label_stamina";
            this.label_stamina.Size = new System.Drawing.Size(10, 13);
            this.label_stamina.TabIndex = 18;
            this.label_stamina.Text = "-";
            // 
            // label_hp
            // 
            this.label_hp.AutoSize = true;
            this.label_hp.Location = new System.Drawing.Point(63, 29);
            this.label_hp.Name = "label_hp";
            this.label_hp.Size = new System.Drawing.Size(10, 13);
            this.label_hp.TabIndex = 19;
            this.label_hp.Text = "-";
            // 
            // label_bagimlilik
            // 
            this.label_bagimlilik.AutoSize = true;
            this.label_bagimlilik.Location = new System.Drawing.Point(63, 42);
            this.label_bagimlilik.Name = "label_bagimlilik";
            this.label_bagimlilik.Size = new System.Drawing.Size(10, 13);
            this.label_bagimlilik.TabIndex = 20;
            this.label_bagimlilik.Text = "-";
            // 
            // label_soygun_gucu
            // 
            this.label_soygun_gucu.AutoSize = true;
            this.label_soygun_gucu.Location = new System.Drawing.Point(90, 145);
            this.label_soygun_gucu.Name = "label_soygun_gucu";
            this.label_soygun_gucu.Size = new System.Drawing.Size(10, 13);
            this.label_soygun_gucu.TabIndex = 21;
            this.label_soygun_gucu.Text = "-";
            // 
            // label_para
            // 
            this.label_para.AutoSize = true;
            this.label_para.Location = new System.Drawing.Point(90, 132);
            this.label_para.Name = "label_para";
            this.label_para.Size = new System.Drawing.Size(10, 13);
            this.label_para.TabIndex = 22;
            this.label_para.Text = "-";
            // 
            // label_tolerans
            // 
            this.label_tolerans.AutoSize = true;
            this.label_tolerans.Location = new System.Drawing.Point(127, 110);
            this.label_tolerans.Name = "label_tolerans";
            this.label_tolerans.Size = new System.Drawing.Size(10, 13);
            this.label_tolerans.TabIndex = 23;
            this.label_tolerans.Text = "-";
            // 
            // label_karizma
            // 
            this.label_karizma.AutoSize = true;
            this.label_karizma.Location = new System.Drawing.Point(19, 110);
            this.label_karizma.Name = "label_karizma";
            this.label_karizma.Size = new System.Drawing.Size(10, 13);
            this.label_karizma.TabIndex = 24;
            this.label_karizma.Text = "-";
            // 
            // label_str
            // 
            this.label_str.AutoSize = true;
            this.label_str.Location = new System.Drawing.Point(125, 76);
            this.label_str.Name = "label_str";
            this.label_str.Size = new System.Drawing.Size(10, 13);
            this.label_str.TabIndex = 25;
            this.label_str.Text = "-";
            // 
            // label_int
            // 
            this.label_int.AutoSize = true;
            this.label_int.Location = new System.Drawing.Point(13, 76);
            this.label_int.Name = "label_int";
            this.label_int.Size = new System.Drawing.Size(10, 13);
            this.label_int.TabIndex = 26;
            this.label_int.Text = "-";
            // 
            // button_bara_git
            // 
            this.button_bara_git.Location = new System.Drawing.Point(12, 173);
            this.button_bara_git.Name = "button_bara_git";
            this.button_bara_git.Size = new System.Drawing.Size(75, 23);
            this.button_bara_git.TabIndex = 11;
            this.button_bara_git.Text = "Enerji Yenile";
            this.button_bara_git.UseVisualStyleBackColor = true;
            // 
            // button_kontakt_detektor
            // 
            this.button_kontakt_detektor.BackColor = System.Drawing.Color.SandyBrown;
            this.button_kontakt_detektor.Location = new System.Drawing.Point(691, 248);
            this.button_kontakt_detektor.Name = "button_kontakt_detektor";
            this.button_kontakt_detektor.Size = new System.Drawing.Size(38, 32);
            this.button_kontakt_detektor.TabIndex = 12;
            this.button_kontakt_detektor.UseVisualStyleBackColor = false;
            this.button_kontakt_detektor.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // checkBox_acil_cikis
            // 
            this.checkBox_acil_cikis.AutoSize = true;
            this.checkBox_acil_cikis.Location = new System.Drawing.Point(93, 177);
            this.checkBox_acil_cikis.Name = "checkBox_acil_cikis";
            this.checkBox_acil_cikis.Size = new System.Drawing.Size(117, 17);
            this.checkBox_acil_cikis.TabIndex = 13;
            this.checkBox_acil_cikis.Text = "Kontaktta Acil Çıkış";
            this.checkBox_acil_cikis.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(638, 228);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(139, 17);
            this.label13.TabIndex = 14;
            this.label13.Text = "Kontakt Detektörü";
            // 
            // button_unhide_hide_browser
            // 
            this.button_unhide_hide_browser.Location = new System.Drawing.Point(215, 22);
            this.button_unhide_hide_browser.Name = "button_unhide_hide_browser";
            this.button_unhide_hide_browser.Size = new System.Drawing.Size(167, 78);
            this.button_unhide_hide_browser.TabIndex = 15;
            this.button_unhide_hide_browser.Text = "Siteyi Göster/ Gizle";
            this.button_unhide_hide_browser.UseVisualStyleBackColor = true;
            this.button_unhide_hide_browser.Click += new System.EventHandler(this.button_unhide_hide_browser_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Serador Bot";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox textBox_pw;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox_soygun_listesi;
        private System.Windows.Forms.Button button_soygun_yap;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label_bagimlilik;
        private System.Windows.Forms.Label label_hp;
        private System.Windows.Forms.Label label_stamina;
        private System.Windows.Forms.Label label_soygun_gucu;
        private System.Windows.Forms.Label label_para;
        private System.Windows.Forms.Label label_tolerans;
        private System.Windows.Forms.Label label_karizma;
        private System.Windows.Forms.Label label_str;
        private System.Windows.Forms.Label label_int;
        private System.Windows.Forms.CheckBox checkBox_acil_cikis;
        private System.Windows.Forms.Button button_kontakt_detektor;
        private System.Windows.Forms.Button button_bara_git;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button_unhide_hide_browser;
    }
}

