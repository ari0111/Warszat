namespace WindowsFormsApplication1
{
    partial class klient_prywatny
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtImie = new System.Windows.Forms.TextBox();
            this.txtNazwisko = new System.Windows.Forms.TextBox();
            this.txtMiasto = new System.Windows.Forms.TextBox();
            this.txtUlica = new System.Windows.Forms.TextBox();
            this.txtKodPocztowy = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.klientPrywatnyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwiskoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.miastoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ulicaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodPocztowyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.database1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new WindowsFormsApplication1.Database1DataSet();
            this.klientPrywatnyTableAdapter = new WindowsFormsApplication1.Database1DataSetTableAdapters.KlientPrywatnyTableAdapter();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klientPrywatnyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Imie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nazwisko";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Miasto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ulica";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Kod Pocztowy";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Telefon";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Email";
            // 
            // txtImie
            // 
            this.txtImie.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.klientPrywatnyBindingSource, "Imie", true));
            this.txtImie.Location = new System.Drawing.Point(141, 18);
            this.txtImie.Name = "txtImie";
            this.txtImie.Size = new System.Drawing.Size(222, 20);
            this.txtImie.TabIndex = 7;
            // 
            // txtNazwisko
            // 
            this.txtNazwisko.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.klientPrywatnyBindingSource, "Nazwisko", true));
            this.txtNazwisko.Location = new System.Drawing.Point(141, 48);
            this.txtNazwisko.Name = "txtNazwisko";
            this.txtNazwisko.Size = new System.Drawing.Size(222, 20);
            this.txtNazwisko.TabIndex = 8;
            // 
            // txtMiasto
            // 
            this.txtMiasto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.klientPrywatnyBindingSource, "Miasto", true));
            this.txtMiasto.Location = new System.Drawing.Point(141, 78);
            this.txtMiasto.Name = "txtMiasto";
            this.txtMiasto.Size = new System.Drawing.Size(222, 20);
            this.txtMiasto.TabIndex = 9;
            // 
            // txtUlica
            // 
            this.txtUlica.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.klientPrywatnyBindingSource, "Ulica", true));
            this.txtUlica.Location = new System.Drawing.Point(141, 110);
            this.txtUlica.Name = "txtUlica";
            this.txtUlica.Size = new System.Drawing.Size(222, 20);
            this.txtUlica.TabIndex = 10;
            // 
            // txtKodPocztowy
            // 
            this.txtKodPocztowy.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.klientPrywatnyBindingSource, "KodPocztowy", true));
            this.txtKodPocztowy.Location = new System.Drawing.Point(141, 142);
            this.txtKodPocztowy.Name = "txtKodPocztowy";
            this.txtKodPocztowy.Size = new System.Drawing.Size(222, 20);
            this.txtKodPocztowy.TabIndex = 11;
            // 
            // txtTelefon
            // 
            this.txtTelefon.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.klientPrywatnyBindingSource, "Telefon", true));
            this.txtTelefon.Location = new System.Drawing.Point(141, 170);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(222, 20);
            this.txtTelefon.TabIndex = 12;
            // 
            // txtEmail
            // 
            this.txtEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.klientPrywatnyBindingSource, "Email", true));
            this.txtEmail.Location = new System.Drawing.Point(141, 200);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(222, 20);
            this.txtEmail.TabIndex = 13;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.imieDataGridViewTextBoxColumn,
            this.nazwiskoDataGridViewTextBoxColumn,
            this.miastoDataGridViewTextBoxColumn,
            this.ulicaDataGridViewTextBoxColumn,
            this.kodPocztowyDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.klientPrywatnyBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(15, 246);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(849, 249);
            this.dataGridView1.TabIndex = 14;
            // 
            // klientPrywatnyBindingSource
            // 
            this.klientPrywatnyBindingSource.DataMember = "KlientPrywatny";
            this.klientPrywatnyBindingSource.DataSource = this.database1DataSetBindingSource;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(546, 501);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Dodaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(627, 501);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Zapisz";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(708, 501);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 17;
            this.button3.Text = "Edytuj";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(789, 501);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 18;
            this.button4.Text = "Zakończ";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // imieDataGridViewTextBoxColumn
            // 
            this.imieDataGridViewTextBoxColumn.DataPropertyName = "Imie";
            this.imieDataGridViewTextBoxColumn.HeaderText = "Imie";
            this.imieDataGridViewTextBoxColumn.Name = "imieDataGridViewTextBoxColumn";
            // 
            // nazwiskoDataGridViewTextBoxColumn
            // 
            this.nazwiskoDataGridViewTextBoxColumn.DataPropertyName = "Nazwisko";
            this.nazwiskoDataGridViewTextBoxColumn.HeaderText = "Nazwisko";
            this.nazwiskoDataGridViewTextBoxColumn.Name = "nazwiskoDataGridViewTextBoxColumn";
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
            this.kodPocztowyDataGridViewTextBoxColumn.DataPropertyName = "KodPocztowy";
            this.kodPocztowyDataGridViewTextBoxColumn.HeaderText = "KodPocztowy";
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
            // database1DataSetBindingSource
            // 
            this.database1DataSetBindingSource.DataSource = this.database1DataSet;
            this.database1DataSetBindingSource.Position = 0;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // klientPrywatnyTableAdapter
            // 
            this.klientPrywatnyTableAdapter.ClearBeforeFill = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(585, 528);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(243, 23);
            this.button5.TabIndex = 19;
            this.button5.Text = "Zakończ Edycje";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // klient_prywatny
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 563);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.txtKodPocztowy);
            this.Controls.Add(this.txtUlica);
            this.Controls.Add(this.txtMiasto);
            this.Controls.Add(this.txtNazwisko);
            this.Controls.Add(this.txtImie);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "klient_prywatny";
            this.Text = "klient_prywatny";
            this.Load += new System.EventHandler(this.klient_prywatny_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klientPrywatnyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtImie;
        private System.Windows.Forms.TextBox txtNazwisko;
        private System.Windows.Forms.TextBox txtMiasto;
        private System.Windows.Forms.TextBox txtUlica;
        private System.Windows.Forms.TextBox txtKodPocztowy;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource database1DataSetBindingSource;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource klientPrywatnyBindingSource;
        private Database1DataSetTableAdapters.KlientPrywatnyTableAdapter klientPrywatnyTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwiskoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn miastoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ulicaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodPocztowyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}