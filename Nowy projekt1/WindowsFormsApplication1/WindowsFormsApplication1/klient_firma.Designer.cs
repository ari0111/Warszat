namespace WindowsFormsApplication1
{
    partial class klient_firma
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
            this.Nowy = new System.Windows.Forms.Button();
            this.Zapisz = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNazwaFirmy = new System.Windows.Forms.TextBox();
            this.txtNIP = new System.Windows.Forms.TextBox();
            this.txtMiasto = new System.Windows.Forms.TextBox();
            this.txtUlica = new System.Windows.Forms.TextBox();
            this.txtKodPocztowy = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.database1DataSet = new WindowsFormsApplication1.Database1DataSet();
            this.klientFirmaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.klientFirmaTableAdapter = new WindowsFormsApplication1.Database1DataSetTableAdapters.KlientFirmaTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwaFirmyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nIPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.miastoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ulicaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodPocztowyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edytuj = new System.Windows.Forms.Button();
            this.Zamknij = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klientFirmaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Nowy
            // 
            this.Nowy.Location = new System.Drawing.Point(514, 495);
            this.Nowy.Name = "Nowy";
            this.Nowy.Size = new System.Drawing.Size(75, 23);
            this.Nowy.TabIndex = 0;
            this.Nowy.Text = "Dodaj";
            this.Nowy.UseVisualStyleBackColor = true;
            this.Nowy.Click += new System.EventHandler(this.Nowy_Click);
            // 
            // Zapisz
            // 
            this.Zapisz.Location = new System.Drawing.Point(595, 495);
            this.Zapisz.Name = "Zapisz";
            this.Zapisz.Size = new System.Drawing.Size(75, 23);
            this.Zapisz.TabIndex = 1;
            this.Zapisz.Text = "Zapisz";
            this.Zapisz.UseVisualStyleBackColor = true;
            this.Zapisz.Click += new System.EventHandler(this.Zapisz_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nazwa Firmy";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "NIP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Miasto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ulica";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Kod Pocztowy";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(70, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Telefon";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(70, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Email";
            // 
            // txtNazwaFirmy
            // 
            this.txtNazwaFirmy.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.klientFirmaBindingSource, "Nazwa Firmy", true));
            this.txtNazwaFirmy.Location = new System.Drawing.Point(161, 37);
            this.txtNazwaFirmy.Name = "txtNazwaFirmy";
            this.txtNazwaFirmy.Size = new System.Drawing.Size(367, 20);
            this.txtNazwaFirmy.TabIndex = 9;
            // 
            // txtNIP
            // 
            this.txtNIP.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.klientFirmaBindingSource, "NIP", true));
            this.txtNIP.Location = new System.Drawing.Point(161, 63);
            this.txtNIP.Name = "txtNIP";
            this.txtNIP.Size = new System.Drawing.Size(367, 20);
            this.txtNIP.TabIndex = 10;
            // 
            // txtMiasto
            // 
            this.txtMiasto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.klientFirmaBindingSource, "Miasto", true));
            this.txtMiasto.Location = new System.Drawing.Point(161, 89);
            this.txtMiasto.Name = "txtMiasto";
            this.txtMiasto.Size = new System.Drawing.Size(367, 20);
            this.txtMiasto.TabIndex = 11;
            // 
            // txtUlica
            // 
            this.txtUlica.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.klientFirmaBindingSource, "Ulica", true));
            this.txtUlica.Location = new System.Drawing.Point(161, 115);
            this.txtUlica.Name = "txtUlica";
            this.txtUlica.Size = new System.Drawing.Size(367, 20);
            this.txtUlica.TabIndex = 12;
            // 
            // txtKodPocztowy
            // 
            this.txtKodPocztowy.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.klientFirmaBindingSource, "Kod Pocztowy", true));
            this.txtKodPocztowy.Location = new System.Drawing.Point(161, 141);
            this.txtKodPocztowy.Name = "txtKodPocztowy";
            this.txtKodPocztowy.Size = new System.Drawing.Size(367, 20);
            this.txtKodPocztowy.TabIndex = 13;
            // 
            // txtTelefon
            // 
            this.txtTelefon.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.klientFirmaBindingSource, "Telefon", true));
            this.txtTelefon.Location = new System.Drawing.Point(161, 167);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(367, 20);
            this.txtTelefon.TabIndex = 14;
            // 
            // txtEmail
            // 
            this.txtEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.klientFirmaBindingSource, "Email", true));
            this.txtEmail.Location = new System.Drawing.Point(161, 193);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(367, 20);
            this.txtEmail.TabIndex = 15;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nazwaFirmyDataGridViewTextBoxColumn,
            this.nIPDataGridViewTextBoxColumn,
            this.miastoDataGridViewTextBoxColumn,
            this.ulicaDataGridViewTextBoxColumn,
            this.kodPocztowyDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.klientFirmaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 219);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(847, 270);
            this.dataGridView1.TabIndex = 16;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // klientFirmaBindingSource
            // 
            this.klientFirmaBindingSource.DataMember = "KlientFirma";
            this.klientFirmaBindingSource.DataSource = this.database1DataSet;
            // 
            // klientFirmaTableAdapter
            // 
            this.klientFirmaTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nazwaFirmyDataGridViewTextBoxColumn
            // 
            this.nazwaFirmyDataGridViewTextBoxColumn.DataPropertyName = "Nazwa Firmy";
            this.nazwaFirmyDataGridViewTextBoxColumn.HeaderText = "Nazwa Firmy";
            this.nazwaFirmyDataGridViewTextBoxColumn.Name = "nazwaFirmyDataGridViewTextBoxColumn";
            // 
            // nIPDataGridViewTextBoxColumn
            // 
            this.nIPDataGridViewTextBoxColumn.DataPropertyName = "NIP";
            this.nIPDataGridViewTextBoxColumn.HeaderText = "NIP";
            this.nIPDataGridViewTextBoxColumn.Name = "nIPDataGridViewTextBoxColumn";
            // 
            // miastoDataGridViewTextBoxColumn
            // 
            this.miastoDataGridViewTextBoxColumn.DataPropertyName = "Miasto";
            this.miastoDataGridViewTextBoxColumn.HeaderText = "Miasto";
            this.miastoDataGridViewTextBoxColumn.Name = "miastoDataGridViewTextBoxColumn";
            // 
            // ulicaDataGridViewTextBoxColumn
            // 
            this.ulicaDataGridViewTextBoxColumn.DataPropertyName = "Ulica";
            this.ulicaDataGridViewTextBoxColumn.HeaderText = "Ulica";
            this.ulicaDataGridViewTextBoxColumn.Name = "ulicaDataGridViewTextBoxColumn";
            // 
            // kodPocztowyDataGridViewTextBoxColumn
            // 
            this.kodPocztowyDataGridViewTextBoxColumn.DataPropertyName = "Kod Pocztowy";
            this.kodPocztowyDataGridViewTextBoxColumn.HeaderText = "Kod Pocztowy";
            this.kodPocztowyDataGridViewTextBoxColumn.Name = "kodPocztowyDataGridViewTextBoxColumn";
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            this.telefonDataGridViewTextBoxColumn.DataPropertyName = "Telefon";
            this.telefonDataGridViewTextBoxColumn.HeaderText = "Telefon";
            this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // Edytuj
            // 
            this.Edytuj.Location = new System.Drawing.Point(676, 495);
            this.Edytuj.Name = "Edytuj";
            this.Edytuj.Size = new System.Drawing.Size(75, 23);
            this.Edytuj.TabIndex = 17;
            this.Edytuj.Text = "Edytuj";
            this.Edytuj.UseVisualStyleBackColor = true;
            this.Edytuj.Click += new System.EventHandler(this.Edytuj_Click);
            // 
            // Zamknij
            // 
            this.Zamknij.Location = new System.Drawing.Point(757, 495);
            this.Zamknij.Name = "Zamknij";
            this.Zamknij.Size = new System.Drawing.Size(75, 23);
            this.Zamknij.TabIndex = 19;
            this.Zamknij.Text = "Zamknij";
            this.Zamknij.UseVisualStyleBackColor = true;
            this.Zamknij.Click += new System.EventHandler(this.Zamknij_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(551, 524);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(237, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Zakończ Edycje";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // klient_firma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 550);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Zamknij);
            this.Controls.Add(this.Edytuj);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.txtKodPocztowy);
            this.Controls.Add(this.txtUlica);
            this.Controls.Add(this.txtMiasto);
            this.Controls.Add(this.txtNIP);
            this.Controls.Add(this.txtNazwaFirmy);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Zapisz);
            this.Controls.Add(this.Nowy);
            this.Name = "klient_firma";
            this.Text = "klient_firma";
            this.Load += new System.EventHandler(this.klient_firma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klientFirmaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Nowy;
        private System.Windows.Forms.Button Zapisz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNazwaFirmy;
        private System.Windows.Forms.TextBox txtNIP;
        private System.Windows.Forms.TextBox txtMiasto;
        private System.Windows.Forms.TextBox txtUlica;
        private System.Windows.Forms.TextBox txtKodPocztowy;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource klientFirmaBindingSource;
        private Database1DataSetTableAdapters.KlientFirmaTableAdapter klientFirmaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwaFirmyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nIPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn miastoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ulicaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodPocztowyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button Edytuj;
        private System.Windows.Forms.Button Zamknij;
        private System.Windows.Forms.Button button1;
    }
}