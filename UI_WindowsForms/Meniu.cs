using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_WindowsForms
{
    public partial class Meniu : Form
    {
        public Meniu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                this.Hide();
                Angajati form1 = new Angajati();
                form1.Show();
            
        }

        private void btnProduse_Click(object sender, EventArgs e)
        {
            this.Hide();
            Produse produse = new Produse();
            produse.Show();
        }

        private void pctExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
