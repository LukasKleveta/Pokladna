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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxRok = new System.Windows.Forms.ComboBox();
            this.comboBoxMesic = new System.Windows.Forms.ComboBox();
            this.groupBox.SuspendLayout();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rok";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 549);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listViewPridani);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
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
    }
}

