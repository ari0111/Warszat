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

        private void tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void klient_firma_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.dataSet1.Table);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
