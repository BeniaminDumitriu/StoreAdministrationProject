using LibrarieModele;
using NivelStocareDate;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration; 
using System.Data;
using System.Drawing;
using System.IO; 
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_WindowsForms
{
    public partial class Angajati : Form
    {
        AdministrareAngajati_FisierText adminAngajati;

        public Angajati()
        {
            string fisierAngajati = ConfigurationManager.AppSettings["fisierAngajati"];
            string locatieFisierSolutie = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string caleCompletaFisier = locatieFisierSolutie + "\\" + fisierAngajati;
            adminAngajati = new AdministrareAngajati_FisierText(caleCompletaFisier);

            InitializeComponent();

            List<Angajat> angajati = adminAngajati.GetAngajati();
            AfisareAngajatiInControlDataGridView(angajati);
        }

        private void buttonexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void adaugarefisier_Click(object sender, EventArgs e)
        {
            int varsta;
            Int32.TryParse(txtVarsta.Text, out varsta);

            if (txtNumeAngajat.Text == string.Empty || txtPrenumeAngajat.Text == "" || txtJob.Text == "")
                MessageBox.Show("Introduceți datele angajatului! ");
            else if (varsta == 0 || varsta > 65 || varsta < 16)
                MessageBox.Show("Varsta nu este corecta");
            else
            {
                Angajat angajatNou = new Angajat(0, txtNumeAngajat.Text, txtPrenumeAngajat.Text, varsta, txtJob.Text);
                adminAngajati.AddAngajat(angajatNou);
                MessageBox.Show("Angajatul a fost adaugat cu succes");
                ResetareControale();
            }

        }
        private void ResetareControale()
        {
            txtNumeAngajat.Text = txtPrenumeAngajat.Text = txtVarsta.Text = txtJob.Text = null;

        }
        private void buttonAfisare_Click(object sender, EventArgs e)
        {
            List<Angajat> angajati = adminAngajati.GetAngajati();

            AfisareAngajatiInControlDataGridView(angajati);
        }

        private void btnCautareAngajat_Click_1(object sender, EventArgs e)
        {
            List<Angajat> angajati = adminAngajati.GetAngajati();
            ArrayList angajatiGasiti = new ArrayList();

            if (txtNumeAngajat.Text != "")
            {

                foreach (Angajat angajat in angajati)
                {
                   if(angajat.nume==txtNumeAngajat.Text)
                    {
                        angajatiGasiti.Add(angajat);
                    }
                }
                AfisareAngajatiInControlDataGridView(angajatiGasiti.Cast<Angajat>().ToList());
                ResetareControale();
            }
            else
                MessageBox.Show("Introduceți numele angajatului! ");
        }

        private void btnStergereAngajat_Click(object sender, EventArgs e)
        {
            List<Angajat> angajati = adminAngajati.GetAngajati();
            foreach (Angajat angajat in angajati)
            {
                if (txtNumeAngajat.Text == angajat.nume && txtPrenumeAngajat.Text == angajat.prenume)
                {
                    adminAngajati.StergereAngajat(angajat);
                    }
            }
            angajati = adminAngajati.GetAngajati();
            AfisareAngajatiInControlDataGridView(angajati.Cast<Angajat>().ToList());
            ResetareControale();
        }

        private void AfisareAngajatiInControlDataGridView(List<Angajat> angajati)
        {
            dataGridAngajati.DataSource = null;
            dataGridAngajati.DataSource = angajati;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Meniu meniu = new Meniu();
            meniu.Show();
        }
    }
}
