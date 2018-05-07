namespace TestComponent
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxCodiceFiscale = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.cognome = new System.Windows.Forms.Label();
            this.nome = new System.Windows.Forms.Label();
            this.regione = new System.Windows.Forms.Label();
            this.provincia = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cidicefiscale = new System.Windows.Forms.Label();
            this.datanascita = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sessoDropDownList1 = new CFComponentN18.SessoDropDownList.SessoDropDownList(this.components);
            this.regioniDropDownList1 = new CFComponentN18.RegioniDropDownList.RegioniDropDownList(this.components);
            this.comuniDropDownList1 = new CFComponentN18.ComuniDropDownList.ComuniDropDownList(this.components);
            this.dataNascitaPicker1 = new CFComponentN18.DataNascitaPicker.DataNascitaPicker(this.components);
            this.provinceDropDownList1 = new CFComponentN18.ProvinceDropDownList.ProvinceDropDownList(this.components);
            this.nomeTextBox1 = new CFComponentN18.NomeTextBox.NomeTextBox(this.components);
            this.cognomeTextBox1 = new CFComponentN18.CognomeTextBox.CognomeTextBox(this.components);
            this.cfComponent1 = new CFComponentN18.CFComponent(this.components);
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(525, 483);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Calc";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxCodiceFiscale
            // 
            this.textBoxCodiceFiscale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCodiceFiscale.Location = new System.Drawing.Point(121, 437);
            this.textBoxCodiceFiscale.Name = "textBoxCodiceFiscale";
            this.textBoxCodiceFiscale.ReadOnly = true;
            this.textBoxCodiceFiscale.Size = new System.Drawing.Size(479, 27);
            this.textBoxCodiceFiscale.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(866, 558);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cognome
            // 
            this.cognome.AutoSize = true;
            this.cognome.Location = new System.Drawing.Point(130, 75);
            this.cognome.Name = "cognome";
            this.cognome.Size = new System.Drawing.Size(68, 17);
            this.cognome.TabIndex = 8;
            this.cognome.Text = "Cognome";
            // 
            // nome
            // 
            this.nome.AutoSize = true;
            this.nome.Location = new System.Drawing.Point(402, 76);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(45, 17);
            this.nome.TabIndex = 9;
            this.nome.Text = "Nome";
            // 
            // regione
            // 
            this.regione.AutoSize = true;
            this.regione.Location = new System.Drawing.Point(130, 155);
            this.regione.Name = "regione";
            this.regione.Size = new System.Drawing.Size(127, 17);
            this.regione.TabIndex = 10;
            this.regione.Text = "Regione di Nascita";
            // 
            // provincia
            // 
            this.provincia.AutoSize = true;
            this.provincia.Location = new System.Drawing.Point(402, 157);
            this.provincia.Name = "provincia";
            this.provincia.Size = new System.Drawing.Size(132, 17);
            this.provincia.TabIndex = 11;
            this.provincia.Text = "Provincia di Nascita";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(131, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Comune di Nascita";
            // 
            // cidicefiscale
            // 
            this.cidicefiscale.AutoSize = true;
            this.cidicefiscale.Location = new System.Drawing.Point(124, 415);
            this.cidicefiscale.Name = "cidicefiscale";
            this.cidicefiscale.Size = new System.Drawing.Size(99, 17);
            this.cidicefiscale.TabIndex = 13;
            this.cidicefiscale.Text = "Codice Fiscale";
            // 
            // datanascita
            // 
            this.datanascita.AutoSize = true;
            this.datanascita.Location = new System.Drawing.Point(129, 331);
            this.datanascita.Name = "datanascita";
            this.datanascita.Size = new System.Drawing.Size(104, 17);
            this.datanascita.TabIndex = 15;
            this.datanascita.Text = "Data di Nascita";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(51, 176);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(70, 22);
            this.textBox1.TabIndex = 27;
            this.textBox1.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(606, 180);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(70, 22);
            this.textBox2.TabIndex = 28;
            this.textBox2.Visible = false;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(612, 263);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(70, 22);
            this.textBox3.TabIndex = 29;
            this.textBox3.Visible = false;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(688, 263);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 30;
            this.textBox4.Visible = false;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(794, 263);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(64, 22);
            this.textBox5.TabIndex = 31;
            this.textBox5.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(660, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 33;
            this.label1.Text = "Sesso";
            // 
            // sessoDropDownList1
            // 
            this.sessoDropDownList1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sessoDropDownList1.FormattingEnabled = true;
            this.sessoDropDownList1.Location = new System.Drawing.Point(657, 98);
            this.sessoDropDownList1.Name = "sessoDropDownList1";
            this.sessoDropDownList1.Size = new System.Drawing.Size(131, 24);
            this.sessoDropDownList1.TabIndex = 34;
            // 
            // regioniDropDownList1
            // 
            this.regioniDropDownList1.DisplayMember = "denominazione_regione";
            this.regioniDropDownList1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.regioniDropDownList1.FormattingEnabled = true;
            this.regioniDropDownList1.Location = new System.Drawing.Point(127, 176);
            this.regioniDropDownList1.Name = "regioniDropDownList1";
            this.regioniDropDownList1.Size = new System.Drawing.Size(201, 24);
            this.regioniDropDownList1.TabIndex = 26;
            this.regioniDropDownList1.ValueMember = "codice_regione";
            this.regioniDropDownList1.RegioneSelectedValueChanged += new CFComponentN18.RegioniDropDownList.RegioniDropDownList.RegioneSelectedEventHandler(this.regioniDropDownList1_RegioneSelectedValueChanged);
            // 
            // comuniDropDownList1
            // 
            this.comuniDropDownList1.CodiceComune = null;
            this.comuniDropDownList1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comuniDropDownList1.FormattingEnabled = true;
            this.comuniDropDownList1.Location = new System.Drawing.Point(127, 261);
            this.comuniDropDownList1.Name = "comuniDropDownList1";
            this.comuniDropDownList1.Provincia = null;
            this.comuniDropDownList1.Size = new System.Drawing.Size(479, 24);
            this.comuniDropDownList1.TabIndex = 25;
            this.comuniDropDownList1.ComuneSelectedValueChanged += new CFComponentN18.ComuniDropDownList.ComuniDropDownList.ComuneSelectedEventHandler(this.comuniDropDownList1_ComuneSelectedValueChanged);
            // 
            // dataNascitaPicker1
            // 
            this.dataNascitaPicker1.Location = new System.Drawing.Point(127, 352);
            this.dataNascitaPicker1.Name = "dataNascitaPicker1";
            this.dataNascitaPicker1.Size = new System.Drawing.Size(274, 22);
            this.dataNascitaPicker1.TabIndex = 24;
            // 
            // provinceDropDownList1
            // 
            this.provinceDropDownList1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.provinceDropDownList1.FormattingEnabled = true;
            this.provinceDropDownList1.Location = new System.Drawing.Point(399, 178);
            this.provinceDropDownList1.Name = "provinceDropDownList1";
            this.provinceDropDownList1.Size = new System.Drawing.Size(201, 24);
            this.provinceDropDownList1.TabIndex = 22;
            this.provinceDropDownList1.ProvinciaSelectedValueChanged += new CFComponentN18.ProvinceDropDownList.ProvinceDropDownList.ProvinciaSelectedEventHandler(this.provinceDropDownList1_ProvinciaSelectedValueChanged);
            // 
            // nomeTextBox1
            // 
            this.nomeTextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.nomeTextBox1.Location = new System.Drawing.Point(399, 98);
            this.nomeTextBox1.Name = "nomeTextBox1";
            this.nomeTextBox1.ShortcutsEnabled = false;
            this.nomeTextBox1.Size = new System.Drawing.Size(201, 22);
            this.nomeTextBox1.TabIndex = 20;
            // 
            // cognomeTextBox1
            // 
            this.cognomeTextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cognomeTextBox1.Location = new System.Drawing.Point(127, 96);
            this.cognomeTextBox1.Name = "cognomeTextBox1";
            this.cognomeTextBox1.ShortcutsEnabled = false;
            this.cognomeTextBox1.Size = new System.Drawing.Size(201, 22);
            this.cognomeTextBox1.TabIndex = 19;
            // 
            // cfComponent1
            // 
            this.cfComponent1.CognomeTextBox = this.cognomeTextBox1;
            this.cfComponent1.ComuniDropDownList = this.comuniDropDownList1;
            this.cfComponent1.DataNascitaPicker = this.dataNascitaPicker1;
            this.cfComponent1.NomeTextBox = this.nomeTextBox1;
            this.cfComponent1.ProvinceDropDownList = this.provinceDropDownList1;
            this.cfComponent1.RegioniDropDownList = this.regioniDropDownList1;
            this.cfComponent1.SessoDropDownList = this.sessoDropDownList1;
            this.cfComponent1.AfterCodeCalculated += new CFComponentN18.CFComponent.AfterCalculatedEventHandler(this.cfComponent1_AfterCodeCalculated);
            this.cfComponent1.BeforeCodeCalculate += new CFComponentN18.CFComponent.BeforeCalculateEventHandler(this.cfComponent1_BeforeCodeCalculate);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 593);
            this.Controls.Add(this.sessoDropDownList1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.regioniDropDownList1);
            this.Controls.Add(this.comuniDropDownList1);
            this.Controls.Add(this.dataNascitaPicker1);
            this.Controls.Add(this.provinceDropDownList1);
            this.Controls.Add(this.nomeTextBox1);
            this.Controls.Add(this.cognomeTextBox1);
            this.Controls.Add(this.datanascita);
            this.Controls.Add(this.cidicefiscale);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.provincia);
            this.Controls.Add(this.regione);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.cognome);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBoxCodiceFiscale);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Codice Fiscale Component Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxCodiceFiscale;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label cognome;
        private System.Windows.Forms.Label nome;
        private System.Windows.Forms.Label regione;
        private System.Windows.Forms.Label provincia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label cidicefiscale;
        private System.Windows.Forms.Label datanascita;
        private CFComponentN18.CognomeTextBox.CognomeTextBox cognomeTextBox1;
        private CFComponentN18.NomeTextBox.NomeTextBox nomeTextBox1;
        private CFComponentN18.ProvinceDropDownList.ProvinceDropDownList provinceDropDownList1;
        private CFComponentN18.DataNascitaPicker.DataNascitaPicker dataNascitaPicker1;
        private CFComponentN18.ComuniDropDownList.ComuniDropDownList comuniDropDownList1;
        private CFComponentN18.RegioniDropDownList.RegioniDropDownList regioniDropDownList1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label1;
        private CFComponentN18.SessoDropDownList.SessoDropDownList sessoDropDownList1;
        private CFComponentN18.CFComponent cfComponent1;
    }
}

