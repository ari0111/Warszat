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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(klient_firma));
            System.Windows.Forms.Label klientIdLabel;
            System.Windows.Forms.Label nazwa_FirmyLabel;
            System.Windows.Forms.Label nIPLabel;
            System.Windows.Forms.Label ulicaLabel;
            System.Windows.Forms.Label miastoLabel;
            System.Windows.Forms.Label kod_PocztowyLabel;
            System.Windows.Forms.Label telefonLabel;
            System.Windows.Forms.Label emailLabel;
            this.button2 = new System.Windows.Forms.Button();
            this.dataSet1 = new WindowsFormsApplication1.DataSet1();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableTableAdapter = new WindowsFormsApplication1.DataSet1TableAdapters.TableTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication1.DataSet1TableAdapters.TableAdapterManager();
            this.tableBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.tableBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.klientIdTextBox = new System.Windows.Forms.TextBox();
            this.nazwa_FirmyTextBox = new System.Windows.Forms.TextBox();
            this.nIPTextBox = new System.Windows.Forms.TextBox();
            this.ulicaTextBox = new System.Windows.Forms.TextBox();
            this.miastoTextBox = new System.Windows.Forms.TextBox();
            this.kod_PocztowyTextBox = new System.Windows.Forms.TextBox();
            this.telefonTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            klientIdLabel = new System.Windows.Forms.Label();
            nazwa_FirmyLabel = new System.Windows.Forms.Label();
            nIPLabel = new System.Windows.Forms.Label();
            ulicaLabel = new System.Windows.Forms.Label();
            miastoLabel = new System.Windows.Forms.Label();
            kod_PocztowyLabel = new System.Windows.Forms.Label();
            telefonLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingNavigator)).BeginInit();
            this.tableBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(151, 250);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Anuluj";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.dataSet1;
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TableTableAdapter = this.tableTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication1.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tableBindingNavigator
            // 
            this.tableBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tableBindingNavigator.BindingSource = this.tableBindingSource;
            this.tableBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tableBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tableBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tableBindingNavigatorSaveItem});
            this.tableBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tableBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tableBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tableBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tableBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tableBindingNavigator.Name = "tableBindingNavigator";
            this.tableBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tableBindingNavigator.Size = new System.Drawing.Size(288, 25);
            this.tableBindingNavigator.TabIndex = 16;
            this.tableBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // tableBindingNavigatorSaveItem
            // 
            this.tableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tableBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tableBindingNavigatorSaveItem.Image")));
            this.tableBindingNavigatorSaveItem.Name = "tableBindingNavigatorSaveItem";
            this.tableBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.tableBindingNavigatorSaveItem.Text = "Save Data";
            this.tableBindingNavigatorSaveItem.Click += new System.EventHandler(this.tableBindingNavigatorSaveItem_Click);
            // 
            // klientIdLabel
            // 
            klientIdLabel.AutoSize = true;
            klientIdLabel.Location = new System.Drawing.Point(12, 39);
            klientIdLabel.Name = "klientIdLabel";
            klientIdLabel.Size = new System.Drawing.Size(48, 13);
            klientIdLabel.TabIndex = 17;
            klientIdLabel.Text = "Klient Id:";
            // 
            // klientIdTextBox
            // 
            this.klientIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "KlientId", true));
            this.klientIdTextBox.Location = new System.Drawing.Point(96, 36);
            this.klientIdTextBox.Name = "klientIdTextBox";
            this.klientIdTextBox.Size = new System.Drawing.Size(180, 20);
            this.klientIdTextBox.TabIndex = 18;
            // 
            // nazwa_FirmyLabel
            // 
            nazwa_FirmyLabel.AutoSize = true;
            nazwa_FirmyLabel.Location = new System.Drawing.Point(12, 65);
            nazwa_FirmyLabel.Name = "nazwa_FirmyLabel";
            nazwa_FirmyLabel.Size = new System.Drawing.Size(70, 13);
            nazwa_FirmyLabel.TabIndex = 19;
            nazwa_FirmyLabel.Text = "Nazwa Firmy:";
            // 
            // nazwa_FirmyTextBox
            // 
            this.nazwa_FirmyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Nazwa Firmy", true));
            this.nazwa_FirmyTextBox.Location = new System.Drawing.Point(96, 62);
            this.nazwa_FirmyTextBox.Name = "nazwa_FirmyTextBox";
            this.nazwa_FirmyTextBox.Size = new System.Drawing.Size(180, 20);
            this.nazwa_FirmyTextBox.TabIndex = 20;
            // 
            // nIPLabel
            // 
            nIPLabel.AutoSize = true;
            nIPLabel.Location = new System.Drawing.Point(12, 91);
            nIPLabel.Name = "nIPLabel";
            nIPLabel.Size = new System.Drawing.Size(28, 13);
            nIPLabel.TabIndex = 21;
            nIPLabel.Text = "NIP:";
            // 
            // nIPTextBox
            // 
            this.nIPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "NIP", true));
            this.nIPTextBox.Location = new System.Drawing.Point(96, 88);
            this.nIPTextBox.Name = "nIPTextBox";
            this.nIPTextBox.Size = new System.Drawing.Size(180, 20);
            this.nIPTextBox.TabIndex = 22;
            // 
            // ulicaLabel
            // 
            ulicaLabel.AutoSize = true;
            ulicaLabel.Location = new System.Drawing.Point(12, 117);
            ulicaLabel.Name = "ulicaLabel";
            ulicaLabel.Size = new System.Drawing.Size(34, 13);
            ulicaLabel.TabIndex = 23;
            ulicaLabel.Text = "Ulica:";
            // 
            // ulicaTextBox
            // 
            this.ulicaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Ulica", true));
            this.ulicaTextBox.Location = new System.Drawing.Point(96, 114);
            this.ulicaTextBox.Name = "ulicaTextBox";
            this.ulicaTextBox.Size = new System.Drawing.Size(180, 20);
            this.ulicaTextBox.TabIndex = 24;
            // 
            // miastoLabel
            // 
            miastoLabel.AutoSize = true;
            miastoLabel.Location = new System.Drawing.Point(12, 143);
            miastoLabel.Name = "miastoLabel";
            miastoLabel.Size = new System.Drawing.Size(41, 13);
            miastoLabel.TabIndex = 25;
            miastoLabel.Text = "Miasto:";
            // 
            // miastoTextBox
            // 
            this.miastoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Miasto", true));
            this.miastoTextBox.Location = new System.Drawing.Point(96, 140);
            this.miastoTextBox.Name = "miastoTextBox";
            this.miastoTextBox.Size = new System.Drawing.Size(180, 20);
            this.miastoTextBox.TabIndex = 26;
            // 
            // kod_PocztowyLabel
            // 
            kod_PocztowyLabel.AutoSize = true;
            kod_PocztowyLabel.Location = new System.Drawing.Point(12, 169);
            kod_PocztowyLabel.Name = "kod_PocztowyLabel";
            kod_PocztowyLabel.Size = new System.Drawing.Size(78, 13);
            kod_PocztowyLabel.TabIndex = 27;
            kod_PocztowyLabel.Text = "Kod Pocztowy:";
            // 
            // kod_PocztowyTextBox
            // 
            this.kod_PocztowyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Kod Pocztowy", true));
            this.kod_PocztowyTextBox.Location = new System.Drawing.Point(96, 166);
            this.kod_PocztowyTextBox.Name = "kod_PocztowyTextBox";
            this.kod_PocztowyTextBox.Size = new System.Drawing.Size(180, 20);
            this.kod_PocztowyTextBox.TabIndex = 28;
            // 
            // telefonLabel
            // 
            telefonLabel.AutoSize = true;
            telefonLabel.Location = new System.Drawing.Point(12, 195);
            telefonLabel.Name = "telefonLabel";
            telefonLabel.Size = new System.Drawing.Size(46, 13);
            telefonLabel.TabIndex = 29;
            telefonLabel.Text = "Telefon:";
            // 
            // telefonTextBox
            // 
            this.telefonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Telefon", true));
            this.telefonTextBox.Location = new System.Drawing.Point(96, 192);
            this.telefonTextBox.Name = "telefonTextBox";
            this.telefonTextBox.Size = new System.Drawing.Size(180, 20);
            this.telefonTextBox.TabIndex = 30;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(12, 221);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 31;
            emailLabel.Text = "Email:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(96, 218);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(180, 20);
            this.emailTextBox.TabIndex = 32;
            // 
            // klient_firma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 323);
            this.Controls.Add(klientIdLabel);
            this.Controls.Add(this.klientIdTextBox);
            this.Controls.Add(nazwa_FirmyLabel);
            this.Controls.Add(this.nazwa_FirmyTextBox);
            this.Controls.Add(nIPLabel);
            this.Controls.Add(this.nIPTextBox);
            this.Controls.Add(ulicaLabel);
            this.Controls.Add(this.ulicaTextBox);
            this.Controls.Add(miastoLabel);
            this.Controls.Add(this.miastoTextBox);
            this.Controls.Add(kod_PocztowyLabel);
            this.Controls.Add(this.kod_PocztowyTextBox);
            this.Controls.Add(telefonLabel);
            this.Controls.Add(this.telefonTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.tableBindingNavigator);
            this.Controls.Add(this.button2);
            this.Name = "klient_firma";
            this.Text = "klient_firma";
            this.Load += new System.EventHandler(this.klient_firma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingNavigator)).EndInit();
            this.tableBindingNavigator.ResumeLayout(false);
            this.tableBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private DataSet1TableAdapters.TableTableAdapter tableTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tableBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tableBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox klientIdTextBox;
        private System.Windows.Forms.TextBox nazwa_FirmyTextBox;
        private System.Windows.Forms.TextBox nIPTextBox;
        private System.Windows.Forms.TextBox ulicaTextBox;
        private System.Windows.Forms.TextBox miastoTextBox;
        private System.Windows.Forms.TextBox kod_PocztowyTextBox;
        private System.Windows.Forms.TextBox telefonTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
    }
}