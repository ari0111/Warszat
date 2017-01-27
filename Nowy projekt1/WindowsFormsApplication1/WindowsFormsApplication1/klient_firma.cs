using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class klient_firma : Form
    {
        public klient_firma()
        {
            InitializeComponent();
        }

        private void klient_firma_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.KlientFirma' table. You can move, or remove it, as needed.
            this.klientFirmaTableAdapter.Fill(this.database1DataSet.KlientFirma);
            Edit(false);

        }
        private void Edit(bool value)
        {
            txtNazwaFirmy.Enabled = value;
            txtNIP.Enabled = value;
            txtMiasto.Enabled = value;
            txtUlica.Enabled = value;
            txtKodPocztowy.Enabled = value;
            txtTelefon.Enabled = value;
            txtEmail.Enabled = value;

        }

        private void Nowy_Click(object sender, EventArgs e)
        {
         try
            {
                Edit(true);
                database1DataSet.KlientFirma.AddKlientFirmaRow(database1DataSet.KlientFirma.NewKlientFirmaRow());
                klientFirmaBindingSource.MoveLast();
                txtNazwaFirmy.Focus();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                database1DataSet.KlientFirma.RejectChanges();
            }
        }

        private void Zapisz_Click(object sender, EventArgs e)
        {
            try
            {
                Edit(false);
                klientFirmaBindingSource.EndEdit();
                klientFirmaTableAdapter.Update(database1DataSet.KlientFirma);
                dataGridView1.Refresh();
                txtNazwaFirmy.Focus();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                database1DataSet.KlientFirma.RejectChanges();
            }
        }

        private void Zamknij_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Edytuj_Click(object sender, EventArgs e)
        {
            Edit(true);
            txtNazwaFirmy.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Edit(false);
            klientFirmaBindingSource.ResetBindings(false);
        }
    }
}
