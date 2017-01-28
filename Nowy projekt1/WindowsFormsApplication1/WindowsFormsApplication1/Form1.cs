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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            this.Hide(); //ukrywasz form-e
            logowanie fl = new logowanie();
            fl.ShowInTaskbar = false;//nie pokazujesz na pasku zadań
            fl.MaximizeBox = false; //nie ma ikonki maksymalizacji
            fl.MinimizeBox = false; //nie ma ikonki minimalizacji
            fl.ShowDialog();//wyświetlasz
            string login = "login";
            string haslo = "haslo";
            
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Klient form = new Klient();
            form.Show();
        }
    }
}
