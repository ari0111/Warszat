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
    public partial class klient_prywatny : Form
    {
        public klient_prywatny()
        {
            InitializeComponent();
        }

        private void klient_prywatny_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.KlientPrywatny' table. You can move, or remove it, as needed.
            this.klientPrywatnyTableAdapter.Fill(this.database1DataSet.KlientPrywatny);
            Edit(false);

        }
        private void Edit(bool value)
        {
            txtImie.Enabled = value;
            txtNazwisko.Enabled = value;
            txtMiasto.Enabled = value;
            txtUlica.Enabled = value;
            txtKodPocztowy.Enabled = value;
            txtTelefon.Enabled = value;
            txtEmail.Enabled = value;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Edit(true);
                
                database1DataSet.KlientPrywatny.AddKlientPrywatnyRow(database1DataSet.KlientPrywatny.NewKlientPrywatnyRow());
                klientPrywatnyBindingSource.MoveLast();
                txtImie.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                database1DataSet.KlientPrywatny.RejectChanges();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Edit(false);
                klientPrywatnyBindingSource.EndEdit();
                klientPrywatnyTableAdapter.Update(database1DataSet.KlientPrywatny);
                dataGridView1.Refresh();
                txtImie.Focus();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                database1DataSet.KlientPrywatny.RejectChanges();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Edit(true);
            txtImie.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Edit(false);
            klientPrywatnyBindingSource.ResetBindings(false);
        }
    }
}
