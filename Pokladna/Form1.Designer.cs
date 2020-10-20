namespace Pokladna
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.listViewPridani = new System.Windows.Forms.ListView();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.comboBoxMesic = new System.Windows.Forms.ComboBox();
            this.comboBoxRok = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonNovyZaznam = new System.Windows.Forms.Button();
            this.buttonUloz = new System.Windows.Forms.Button();
            this.textBoxPoznamkaDoklad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownCastka = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxPopisDokladu = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxCisloDokladu = new System.Windows.Forms.TextBox();
            this.dateTimePickerDatumDokladu = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCastka)).BeginInit();
            this.SuspendLayout();
            // 
            // listViewPridani
            // 
            this.listViewPridani.Dock = System.Windows.Forms.DockStyle.Right;
            this.listViewPridani.HideSelection = false;
            this.listViewPridani.Location = new System.Drawing.Point(700, 0);
            this.listViewPridani.Name = "listViewPridani";
            this.listViewPridani.Size = new System.Drawing.Size(448, 549);
            this.listViewPridani.TabIndex = 0;
            this.listViewPridani.UseCompatibleStateImageBehavior = false;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView2.FullRowSelect = true;
            this.listView2.GridLines = true;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(0, 0);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(700, 549);
            this.listView2.TabIndex = 1;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Datum";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Číslo dokladu";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Popis";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Příjmy";
            this.columnHeader4.Width = 75;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Výdaje";
            this.columnHeader5.Width = 75;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Zůstatek";
            this.columnHeader6.Width = 75;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Poznámka";
            this.columnHeader7.Width = 180;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.comboBoxMesic);
            this.groupBox.Controls.Add(this.comboBoxRok);
            this.groupBox.Controls.Add(this.label2);
            this.groupBox.Controls.Add(this.label1);
            this.groupBox.Location = new System.Drawing.Point(708, 8);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(428, 125);
            this.groupBox.TabIndex = 2;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Účetní období";
            // 
            // comboBoxMesic
            // 
            this.comboBoxMesic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMesic.FormattingEnabled = true;
            this.comboBoxMesic.Items.AddRange(new object[] {
            "Leden",
            "Únor",
            "Březen",
            "Duben",
            "Květen ",
            "Červen",
            "Červenec",
            "Srpen ",
            "Září ",
            "Říjen ",
            "Listopad",
            "Prosinec"});
            this.comboBoxMesic.Location = new System.Drawing.Point(104, 69);
            this.comboBoxMesic.Name = "comboBoxMesic";
            this.comboBoxMesic.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMesic.TabIndex = 3;
            this.comboBoxMesic.SelectedIndexChanged += new System.EventHandler(this.comboBoxMesic_SelectedIndexChanged);
            // 
            // comboBoxRok
            // 
            this.comboBoxRok.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRok.FormattingEnabled = true;
            this.comboBoxRok.Items.AddRange(new object[] {
            "2018\t",
            "2019",
            "2020",
            "2021"});
            this.comboBoxRok.Location = new System.Drawing.Point(104, 35);
            this.comboBoxRok.Name = "comboBoxRok";
            this.comboBoxRok.Size = new System.Drawing.Size(121, 21);
            this.comboBoxRok.TabIndex = 2;
            this.comboBoxRok.SelectedIndexChanged += new System.EventHandler(this.comboBoxRok_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Měsíc";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rok";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonNovyZaznam);
            this.groupBox1.Controls.Add(this.buttonUloz);
            this.groupBox1.Controls.Add(this.textBoxPoznamkaDoklad);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.numericUpDownCastka);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBoxPopisDokladu);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBoxCisloDokladu);
            this.groupBox1.Controls.Add(this.dateTimePickerDatumDokladu);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(708, 139);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(428, 199);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Doklad";
            // 
            // buttonNovyZaznam
            // 
            this.buttonNovyZaznam.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonNovyZaznam.Location = new System.Drawing.Point(230, 170);
            this.buttonNovyZaznam.Name = "buttonNovyZaznam";
            this.buttonNovyZaznam.Size = new System.Drawing.Size(111, 23);
            this.buttonNovyZaznam.TabIndex = 13;
            this.buttonNovyZaznam.Text = "Nový záznam";
            this.buttonNovyZaznam.UseVisualStyleBackColor = true;
            this.buttonNovyZaznam.Click += new System.EventHandler(this.buttonNovyZaznam_Click);
            // 
            // buttonUloz
            // 
            this.buttonUloz.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonUloz.Location = new System.Drawing.Point(347, 170);
            this.buttonUloz.Name = "buttonUloz";
            this.buttonUloz.Size = new System.Drawing.Size(75, 23);
            this.buttonUloz.TabIndex = 4;
            this.buttonUloz.Text = "Uložit";
            this.buttonUloz.UseVisualStyleBackColor = true;
            // 
            // textBoxPoznamkaDoklad
            // 
            this.textBoxPoznamkaDoklad.Location = new System.Drawing.Point(104, 102);
            this.textBoxPoznamkaDoklad.Name = "textBoxPoznamkaDoklad";
            this.textBoxPoznamkaDoklad.Size = new System.Drawing.Size(200, 20);
            this.textBoxPoznamkaDoklad.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Poznámka";
            // 
            // numericUpDownCastka
            // 
            this.numericUpDownCastka.Location = new System.Drawing.Point(105, 128);
            this.numericUpDownCastka.Maximum = new decimal(new int[] {
            200000,
            0,
            0,
            0});
            this.numericUpDownCastka.Minimum = new decimal(new int[] {
            200000,
            0,
            0,
            -2147483648});
            this.numericUpDownCastka.Name = "numericUpDownCastka";
            this.numericUpDownCastka.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownCastka.TabIndex = 10;
            this.numericUpDownCastka.ValueChanged += new System.EventHandler(this.numericUpDownCastka_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Částka";
            // 
            // textBoxPopisDokladu
            // 
            this.textBoxPopisDokladu.Location = new System.Drawing.Point(104, 78);
            this.textBoxPopisDokladu.Multiline = true;
            this.textBoxPopisDokladu.Name = "textBoxPopisDokladu";
            this.textBoxPopisDokladu.Size = new System.Drawing.Size(200, 18);
            this.textBoxPopisDokladu.TabIndex = 8;
            this.textBoxPopisDokladu.TextChanged += new System.EventHandler(this.textBoxPopisDokladu_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Popis";
            // 
            // textBoxCisloDokladu
            // 
            this.textBoxCisloDokladu.Location = new System.Drawing.Point(104, 52);
            this.textBoxCisloDokladu.Name = "textBoxCisloDokladu";
            this.textBoxCisloDokladu.ReadOnly = true;
            this.textBoxCisloDokladu.Size = new System.Drawing.Size(200, 20);
            this.textBoxCisloDokladu.TabIndex = 6;
            this.textBoxCisloDokladu.TextChanged += new System.EventHandler(this.textBoxCisloDokladu_TextChanged);
            // 
            // dateTimePickerDatumDokladu
            // 
            this.dateTimePickerDatumDokladu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDatumDokladu.Location = new System.Drawing.Point(104, 26);
            this.dateTimePickerDatumDokladu.Name = "dateTimePickerDatumDokladu";
            this.dateTimePickerDatumDokladu.Size = new System.Drawing.Size(100, 20);
            this.dateTimePickerDatumDokladu.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Číslo dokladu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Datum";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 549);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listViewPridani);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCastka)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewPridani;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.ComboBox comboBoxMesic;
        private System.Windows.Forms.ComboBox comboBoxRok;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxPopisDokladu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxCisloDokladu;
        private System.Windows.Forms.DateTimePicker dateTimePickerDatumDokladu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownCastka;
        private System.Windows.Forms.Button buttonNovyZaznam;
        private System.Windows.Forms.Button buttonUloz;
        private System.Windows.Forms.TextBox textBoxPoznamkaDoklad;
        private System.Windows.Forms.Label label5;
    }
}

