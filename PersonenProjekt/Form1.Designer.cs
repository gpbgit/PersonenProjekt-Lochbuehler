
namespace PersonenProjekt
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbVorname = new System.Windows.Forms.TextBox();
            this.tbNachname = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbStrasse = new System.Windows.Forms.TextBox();
            this.tbPlz = new System.Windows.Forms.TextBox();
            this.tbOrt = new System.Windows.Forms.TextBox();
            this.tbKdnNr = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnNeu = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbDivers = new System.Windows.Forms.RadioButton();
            this.rbWeiblich = new System.Windows.Forms.RadioButton();
            this.rbMaennlich = new System.Windows.Forms.RadioButton();
            this.tbGeschlecht = new System.Windows.Forms.TextBox();
            this.lbAnrede = new System.Windows.Forms.Label();
            this.gbAnrede = new System.Windows.Forms.GroupBox();
            this.rbOhne = new System.Windows.Forms.RadioButton();
            this.rbFrau = new System.Windows.Forms.RadioButton();
            this.rbHerr = new System.Windows.Forms.RadioButton();
            this.lbAnzahl = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.gbAnrede.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vorname:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nachname:";
            // 
            // tbVorname
            // 
            this.tbVorname.Location = new System.Drawing.Point(187, 12);
            this.tbVorname.Name = "tbVorname";
            this.tbVorname.Size = new System.Drawing.Size(103, 20);
            this.tbVorname.TabIndex = 2;
            // 
            // tbNachname
            // 
            this.tbNachname.Location = new System.Drawing.Point(187, 39);
            this.tbNachname.Name = "tbNachname";
            this.tbNachname.Size = new System.Drawing.Size(103, 20);
            this.tbNachname.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(185, 308);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 25);
            this.button1.TabIndex = 4;
            this.button1.Text = "Speichern";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(109, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "StrasseNr:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(109, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "PLZ:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(109, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Ort:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(109, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "KdnNr:";
            // 
            // tbStrasse
            // 
            this.tbStrasse.Location = new System.Drawing.Point(187, 59);
            this.tbStrasse.Name = "tbStrasse";
            this.tbStrasse.Size = new System.Drawing.Size(103, 20);
            this.tbStrasse.TabIndex = 11;
            // 
            // tbPlz
            // 
            this.tbPlz.Location = new System.Drawing.Point(187, 83);
            this.tbPlz.Name = "tbPlz";
            this.tbPlz.Size = new System.Drawing.Size(103, 20);
            this.tbPlz.TabIndex = 12;
            // 
            // tbOrt
            // 
            this.tbOrt.Location = new System.Drawing.Point(187, 107);
            this.tbOrt.Name = "tbOrt";
            this.tbOrt.Size = new System.Drawing.Size(103, 20);
            this.tbOrt.TabIndex = 13;
            // 
            // tbKdnNr
            // 
            this.tbKdnNr.Location = new System.Drawing.Point(187, 131);
            this.tbKdnNr.Name = "tbKdnNr";
            this.tbKdnNr.Size = new System.Drawing.Size(103, 20);
            this.tbKdnNr.TabIndex = 14;
            // 
            // listBox1
            // 
            this.listBox1.Enabled = false;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(328, 35);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(171, 173);
            this.listBox1.TabIndex = 15;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnNeu
            // 
            this.btnNeu.Location = new System.Drawing.Point(184, 344);
            this.btnNeu.Name = "btnNeu";
            this.btnNeu.Size = new System.Drawing.Size(104, 22);
            this.btnNeu.TabIndex = 17;
            this.btnNeu.Text = "Neu";
            this.btnNeu.UseVisualStyleBackColor = true;
            this.btnNeu.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(334, 344);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 21);
            this.button2.TabIndex = 18;
            this.button2.Text = "Löschen";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(328, 214);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(168, 21);
            this.comboBox1.TabIndex = 19;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbDivers);
            this.groupBox1.Controls.Add(this.rbWeiblich);
            this.groupBox1.Controls.Add(this.rbMaennlich);
            this.groupBox1.Location = new System.Drawing.Point(28, 189);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 55);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Geschlecht";
            // 
            // rbDivers
            // 
            this.rbDivers.AutoSize = true;
            this.rbDivers.Location = new System.Drawing.Point(174, 20);
            this.rbDivers.Name = "rbDivers";
            this.rbDivers.Size = new System.Drawing.Size(53, 17);
            this.rbDivers.TabIndex = 2;
            this.rbDivers.TabStop = true;
            this.rbDivers.Text = "divers";
            this.rbDivers.UseVisualStyleBackColor = true;
            this.rbDivers.CheckedChanged += new System.EventHandler(this.rbDivers_CheckedChanged);
            // 
            // rbWeiblich
            // 
            this.rbWeiblich.AutoSize = true;
            this.rbWeiblich.Location = new System.Drawing.Point(99, 20);
            this.rbWeiblich.Name = "rbWeiblich";
            this.rbWeiblich.Size = new System.Drawing.Size(63, 17);
            this.rbWeiblich.TabIndex = 1;
            this.rbWeiblich.TabStop = true;
            this.rbWeiblich.Text = "weiblich";
            this.rbWeiblich.UseVisualStyleBackColor = true;
            this.rbWeiblich.CheckedChanged += new System.EventHandler(this.rbWeiblich_CheckedChanged);
            // 
            // rbMaennlich
            // 
            this.rbMaennlich.AutoSize = true;
            this.rbMaennlich.Checked = true;
            this.rbMaennlich.Location = new System.Drawing.Point(17, 20);
            this.rbMaennlich.Name = "rbMaennlich";
            this.rbMaennlich.Size = new System.Drawing.Size(67, 17);
            this.rbMaennlich.TabIndex = 0;
            this.rbMaennlich.TabStop = true;
            this.rbMaennlich.Text = "männlich";
            this.rbMaennlich.UseVisualStyleBackColor = true;
            this.rbMaennlich.CheckedChanged += new System.EventHandler(this.rbMaennlich_CheckedChanged);
            // 
            // tbGeschlecht
            // 
            this.tbGeschlecht.Location = new System.Drawing.Point(187, 157);
            this.tbGeschlecht.Name = "tbGeschlecht";
            this.tbGeschlecht.Size = new System.Drawing.Size(102, 20);
            this.tbGeschlecht.TabIndex = 21;
            // 
            // lbAnrede
            // 
            this.lbAnrede.AutoSize = true;
            this.lbAnrede.Location = new System.Drawing.Point(131, 250);
            this.lbAnrede.Name = "lbAnrede";
            this.lbAnrede.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbAnrede.Size = new System.Drawing.Size(158, 13);
            this.lbAnrede.TabIndex = 22;
            this.lbAnrede.Text = " Sehr gehrte Damen und Herren";
            this.lbAnrede.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // gbAnrede
            // 
            this.gbAnrede.Controls.Add(this.rbOhne);
            this.gbAnrede.Controls.Add(this.rbFrau);
            this.gbAnrede.Controls.Add(this.rbHerr);
            this.gbAnrede.Location = new System.Drawing.Point(31, 266);
            this.gbAnrede.Name = "gbAnrede";
            this.gbAnrede.Size = new System.Drawing.Size(258, 30);
            this.gbAnrede.TabIndex = 23;
            this.gbAnrede.TabStop = false;
            // 
            // rbOhne
            // 
            this.rbOhne.AutoSize = true;
            this.rbOhne.Location = new System.Drawing.Point(191, 8);
            this.rbOhne.Name = "rbOhne";
            this.rbOhne.Size = new System.Drawing.Size(51, 17);
            this.rbOhne.TabIndex = 2;
            this.rbOhne.Text = "Ohne";
            this.rbOhne.UseVisualStyleBackColor = true;
            this.rbOhne.CheckedChanged += new System.EventHandler(this.rbOhne_CheckedChanged);
            // 
            // rbFrau
            // 
            this.rbFrau.AutoSize = true;
            this.rbFrau.Location = new System.Drawing.Point(98, 9);
            this.rbFrau.Name = "rbFrau";
            this.rbFrau.Size = new System.Drawing.Size(46, 17);
            this.rbFrau.TabIndex = 1;
            this.rbFrau.Text = "Frau";
            this.rbFrau.UseVisualStyleBackColor = true;
            this.rbFrau.CheckedChanged += new System.EventHandler(this.rbFrau_CheckedChanged);
            // 
            // rbHerr
            // 
            this.rbHerr.AutoSize = true;
            this.rbHerr.Checked = true;
            this.rbHerr.Location = new System.Drawing.Point(6, 10);
            this.rbHerr.Name = "rbHerr";
            this.rbHerr.Size = new System.Drawing.Size(45, 17);
            this.rbHerr.TabIndex = 0;
            this.rbHerr.TabStop = true;
            this.rbHerr.Text = "Herr";
            this.rbHerr.UseVisualStyleBackColor = true;
            this.rbHerr.CheckedChanged += new System.EventHandler(this.rbHerr_CheckedChanged);
            // 
            // lbAnzahl
            // 
            this.lbAnzahl.AutoSize = true;
            this.lbAnzahl.Location = new System.Drawing.Point(333, 259);
            this.lbAnzahl.Name = "lbAnzahl";
            this.lbAnzahl.Size = new System.Drawing.Size(35, 13);
            this.lbAnzahl.TabIndex = 24;
            this.lbAnzahl.Text = "label3";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(334, 306);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(162, 27);
            this.button3.TabIndex = 25;
            this.button3.Text = "Personen speichern";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 419);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.lbAnzahl);
            this.Controls.Add(this.gbAnrede);
            this.Controls.Add(this.lbAnrede);
            this.Controls.Add(this.tbGeschlecht);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnNeu);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.tbKdnNr);
            this.Controls.Add(this.tbOrt);
            this.Controls.Add(this.tbPlz);
            this.Controls.Add(this.tbStrasse);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbNachname);
            this.Controls.Add(this.tbVorname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Person";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbAnrede.ResumeLayout(false);
            this.gbAnrede.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbVorname;
        private System.Windows.Forms.TextBox tbNachname;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbStrasse;
        private System.Windows.Forms.TextBox tbPlz;
        private System.Windows.Forms.TextBox tbOrt;
        private System.Windows.Forms.TextBox tbKdnNr;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnNeu;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbDivers;
        private System.Windows.Forms.RadioButton rbWeiblich;
        private System.Windows.Forms.RadioButton rbMaennlich;
        private System.Windows.Forms.TextBox tbGeschlecht;
        private System.Windows.Forms.Label lbAnrede;
        private System.Windows.Forms.GroupBox gbAnrede;
        private System.Windows.Forms.RadioButton rbOhne;
        private System.Windows.Forms.RadioButton rbFrau;
        private System.Windows.Forms.RadioButton rbHerr;
        private System.Windows.Forms.Label lbAnzahl;
        private System.Windows.Forms.Button button3;
    }
}

