
namespace ModulzaroVizsga
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox_Hazak = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Cim = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown_Alapterulet = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_Epitesi_anyag = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker_MKezdete = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_MVege = new System.Windows.Forms.DateTimePicker();
            this.button_Modositas = new System.Windows.Forms.Button();
            this.button_Torles = new System.Windows.Forms.Button();
            this.groupBox_Tombhaz = new System.Windows.Forms.GroupBox();
            this.button_Hozzaadas_tombhaz = new System.Windows.Forms.Button();
            this.numericUpDown_Lakasokszama = new System.Windows.Forms.NumericUpDown();
            this.comboBox_LakasfentartasTipusa = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_Hozzaadas = new System.Windows.Forms.Button();
            this.comboBox_Tetotipus = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBox_Garazs = new System.Windows.Forms.CheckBox();
            this.numericUpDown_ottelekok = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox_becsultAr = new System.Windows.Forms.TextBox();
            this.listBox_Aktualis = new System.Windows.Forms.ListBox();
            this.button_Aktualisak = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Alapterulet)).BeginInit();
            this.groupBox_Tombhaz.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Lakasokszama)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ottelekok)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox_Hazak
            // 
            this.listBox_Hazak.FormattingEnabled = true;
            this.listBox_Hazak.ItemHeight = 15;
            this.listBox_Hazak.Location = new System.Drawing.Point(13, 13);
            this.listBox_Hazak.Name = "listBox_Hazak";
            this.listBox_Hazak.Size = new System.Drawing.Size(175, 334);
            this.listBox_Hazak.TabIndex = 0;
            this.listBox_Hazak.SelectedIndexChanged += new System.EventHandler(this.listBox_Hazak_SelectedIndexChanged);
            this.listBox_Hazak.DoubleClick += new System.EventHandler(this.listBox_Hazak_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(195, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cím : ";
            // 
            // textBox_Cim
            // 
            this.textBox_Cim.Location = new System.Drawing.Point(348, 12);
            this.textBox_Cim.Name = "textBox_Cim";
            this.textBox_Cim.Size = new System.Drawing.Size(200, 23);
            this.textBox_Cim.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Alapterület : ";
            // 
            // numericUpDown_Alapterulet
            // 
            this.numericUpDown_Alapterulet.Location = new System.Drawing.Point(348, 71);
            this.numericUpDown_Alapterulet.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_Alapterulet.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown_Alapterulet.Name = "numericUpDown_Alapterulet";
            this.numericUpDown_Alapterulet.Size = new System.Drawing.Size(200, 23);
            this.numericUpDown_Alapterulet.TabIndex = 4;
            this.numericUpDown_Alapterulet.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(195, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Építési anyag : ";
            // 
            // comboBox_Epitesi_anyag
            // 
            this.comboBox_Epitesi_anyag.FormattingEnabled = true;
            this.comboBox_Epitesi_anyag.Items.AddRange(new object[] {
            "Tégla",
            "Panel",
            "Fa"});
            this.comboBox_Epitesi_anyag.Location = new System.Drawing.Point(348, 137);
            this.comboBox_Epitesi_anyag.Name = "comboBox_Epitesi_anyag";
            this.comboBox_Epitesi_anyag.Size = new System.Drawing.Size(200, 23);
            this.comboBox_Epitesi_anyag.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(195, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Munkavégzés Kezdete : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(194, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Munkavégzés Vége : ";
            // 
            // dateTimePicker_MKezdete
            // 
            this.dateTimePicker_MKezdete.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_MKezdete.Location = new System.Drawing.Point(348, 195);
            this.dateTimePicker_MKezdete.Name = "dateTimePicker_MKezdete";
            this.dateTimePicker_MKezdete.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker_MKezdete.TabIndex = 9;
            // 
            // dateTimePicker_MVege
            // 
            this.dateTimePicker_MVege.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_MVege.Location = new System.Drawing.Point(348, 253);
            this.dateTimePicker_MVege.Name = "dateTimePicker_MVege";
            this.dateTimePicker_MVege.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker_MVege.TabIndex = 10;
            // 
            // button_Modositas
            // 
            this.button_Modositas.Location = new System.Drawing.Point(13, 354);
            this.button_Modositas.Name = "button_Modositas";
            this.button_Modositas.Size = new System.Drawing.Size(175, 23);
            this.button_Modositas.TabIndex = 13;
            this.button_Modositas.Text = "Módosítás";
            this.button_Modositas.UseVisualStyleBackColor = true;
            // 
            // button_Torles
            // 
            this.button_Torles.Location = new System.Drawing.Point(13, 399);
            this.button_Torles.Name = "button_Torles";
            this.button_Torles.Size = new System.Drawing.Size(175, 23);
            this.button_Torles.TabIndex = 14;
            this.button_Torles.Text = "Törlés";
            this.button_Torles.UseVisualStyleBackColor = true;
            this.button_Torles.Click += new System.EventHandler(this.button_Torles_Click);
            // 
            // groupBox_Tombhaz
            // 
            this.groupBox_Tombhaz.Controls.Add(this.button_Hozzaadas_tombhaz);
            this.groupBox_Tombhaz.Controls.Add(this.numericUpDown_Lakasokszama);
            this.groupBox_Tombhaz.Controls.Add(this.comboBox_LakasfentartasTipusa);
            this.groupBox_Tombhaz.Controls.Add(this.checkBox1);
            this.groupBox_Tombhaz.Controls.Add(this.label7);
            this.groupBox_Tombhaz.Controls.Add(this.label8);
            this.groupBox_Tombhaz.Location = new System.Drawing.Point(564, 13);
            this.groupBox_Tombhaz.Name = "groupBox_Tombhaz";
            this.groupBox_Tombhaz.Size = new System.Drawing.Size(373, 170);
            this.groupBox_Tombhaz.TabIndex = 17;
            this.groupBox_Tombhaz.TabStop = false;
            this.groupBox_Tombhaz.Text = "Tömbhház";
            // 
            // button_Hozzaadas_tombhaz
            // 
            this.button_Hozzaadas_tombhaz.Location = new System.Drawing.Point(6, 127);
            this.button_Hozzaadas_tombhaz.Name = "button_Hozzaadas_tombhaz";
            this.button_Hozzaadas_tombhaz.Size = new System.Drawing.Size(154, 23);
            this.button_Hozzaadas_tombhaz.TabIndex = 13;
            this.button_Hozzaadas_tombhaz.Text = "Hozzáadás";
            this.button_Hozzaadas_tombhaz.UseVisualStyleBackColor = true;
            this.button_Hozzaadas_tombhaz.Click += new System.EventHandler(this.button_Hozzaadas_tombhaz_Click);
            // 
            // numericUpDown_Lakasokszama
            // 
            this.numericUpDown_Lakasokszama.Location = new System.Drawing.Point(209, 19);
            this.numericUpDown_Lakasokszama.Name = "numericUpDown_Lakasokszama";
            this.numericUpDown_Lakasokszama.Size = new System.Drawing.Size(120, 23);
            this.numericUpDown_Lakasokszama.TabIndex = 12;
            this.numericUpDown_Lakasokszama.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // comboBox_LakasfentartasTipusa
            // 
            this.comboBox_LakasfentartasTipusa.FormattingEnabled = true;
            this.comboBox_LakasfentartasTipusa.Items.AddRange(new object[] {
            "Egyéni",
            "Szövetkezet",
            "Társasház"});
            this.comboBox_LakasfentartasTipusa.Location = new System.Drawing.Point(209, 58);
            this.comboBox_LakasfentartasTipusa.Name = "comboBox_LakasfentartasTipusa";
            this.comboBox_LakasfentartasTipusa.Size = new System.Drawing.Size(121, 23);
            this.comboBox_LakasfentartasTipusa.TabIndex = 11;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(209, 87);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(65, 19);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Van  lift";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "Lakásfenntartás típusa : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "Lakások Száma : ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_Hozzaadas);
            this.groupBox1.Controls.Add(this.comboBox_Tetotipus);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.checkBox_Garazs);
            this.groupBox1.Controls.Add(this.numericUpDown_ottelekok);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(570, 201);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(367, 221);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Családi ház";
            // 
            // button_Hozzaadas
            // 
            this.button_Hozzaadas.Location = new System.Drawing.Point(97, 180);
            this.button_Hozzaadas.Name = "button_Hozzaadas";
            this.button_Hozzaadas.Size = new System.Drawing.Size(139, 23);
            this.button_Hozzaadas.TabIndex = 13;
            this.button_Hozzaadas.Text = "Hozzáadás";
            this.button_Hozzaadas.UseVisualStyleBackColor = true;
            this.button_Hozzaadas.Click += new System.EventHandler(this.button_Hozzaadas_Click);
            // 
            // comboBox_Tetotipus
            // 
            this.comboBox_Tetotipus.FormattingEnabled = true;
            this.comboBox_Tetotipus.Items.AddRange(new object[] {
            "Cserép",
            "Zsindely",
            "Nád"});
            this.comboBox_Tetotipus.Location = new System.Drawing.Point(202, 122);
            this.comboBox_Tetotipus.Name = "comboBox_Tetotipus";
            this.comboBox_Tetotipus.Size = new System.Drawing.Size(121, 23);
            this.comboBox_Tetotipus.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tető típusa : ";
            // 
            // checkBox_Garazs
            // 
            this.checkBox_Garazs.AutoSize = true;
            this.checkBox_Garazs.Location = new System.Drawing.Point(203, 68);
            this.checkBox_Garazs.Name = "checkBox_Garazs";
            this.checkBox_Garazs.Size = new System.Drawing.Size(62, 19);
            this.checkBox_Garazs.TabIndex = 10;
            this.checkBox_Garazs.Text = "Van lift";
            this.checkBox_Garazs.UseVisualStyleBackColor = true;
            // 
            // numericUpDown_ottelekok
            // 
            this.numericUpDown_ottelekok.Location = new System.Drawing.Point(203, 26);
            this.numericUpDown_ottelekok.Name = "numericUpDown_ottelekok";
            this.numericUpDown_ottelekok.Size = new System.Drawing.Size(120, 23);
            this.numericUpDown_ottelekok.TabIndex = 8;
            this.numericUpDown_ottelekok.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 15);
            this.label10.TabIndex = 7;
            this.label10.Text = "Ottélők száma : ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(195, 331);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 15);
            this.label11.TabIndex = 19;
            this.label11.Text = "Becsült Ár  :";
            // 
            // textBox_becsultAr
            // 
            this.textBox_becsultAr.Location = new System.Drawing.Point(348, 331);
            this.textBox_becsultAr.Name = "textBox_becsultAr";
            this.textBox_becsultAr.Size = new System.Drawing.Size(200, 23);
            this.textBox_becsultAr.TabIndex = 20;
            // 
            // listBox_Aktualis
            // 
            this.listBox_Aktualis.FormattingEnabled = true;
            this.listBox_Aktualis.ItemHeight = 15;
            this.listBox_Aktualis.Location = new System.Drawing.Point(943, 25);
            this.listBox_Aktualis.Name = "listBox_Aktualis";
            this.listBox_Aktualis.Size = new System.Drawing.Size(175, 349);
            this.listBox_Aktualis.TabIndex = 21;
            // 
            // button_Aktualisak
            // 
            this.button_Aktualisak.Location = new System.Drawing.Point(943, 381);
            this.button_Aktualisak.Name = "button_Aktualisak";
            this.button_Aktualisak.Size = new System.Drawing.Size(175, 23);
            this.button_Aktualisak.TabIndex = 22;
            this.button_Aktualisak.Text = "Frissít";
            this.button_Aktualisak.UseVisualStyleBackColor = true;
            this.button_Aktualisak.Click += new System.EventHandler(this.button_Aktualisak_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 464);
            this.Controls.Add(this.button_Aktualisak);
            this.Controls.Add(this.listBox_Aktualis);
            this.Controls.Add(this.textBox_becsultAr);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox_Tombhaz);
            this.Controls.Add(this.button_Torles);
            this.Controls.Add(this.button_Modositas);
            this.Controls.Add(this.dateTimePicker_MVege);
            this.Controls.Add(this.dateTimePicker_MKezdete);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox_Epitesi_anyag);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDown_Alapterulet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_Cim);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox_Hazak);
            this.Name = "Form1";
            this.Text = "text";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Alapterulet)).EndInit();
            this.groupBox_Tombhaz.ResumeLayout(false);
            this.groupBox_Tombhaz.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Lakasokszama)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ottelekok)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_Hazak;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Cim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown_Alapterulet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_Epitesi_anyag;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker_MKezdete;
        private System.Windows.Forms.DateTimePicker dateTimePicker_MVege;
        private System.Windows.Forms.Button button_Modositas;
        private System.Windows.Forms.Button button_Torles;
        private System.Windows.Forms.GroupBox groupBox_Tombhaz;
        private System.Windows.Forms.Button button_Hozzaadas_tombhaz;
        private System.Windows.Forms.NumericUpDown numericUpDown_Lakasokszama;
        private System.Windows.Forms.ComboBox comboBox_LakasfentartasTipusa;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_Hozzaadas;
        private System.Windows.Forms.ComboBox comboBox_Tetotipus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBox_Garazs;
        private System.Windows.Forms.NumericUpDown numericUpDown_ottelekok;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox_becsultAr;
        private System.Windows.Forms.ListBox listBox_Aktualis;
        private System.Windows.Forms.Button button_Aktualisak;
    }
}

