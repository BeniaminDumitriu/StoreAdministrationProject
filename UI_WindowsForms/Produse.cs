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
    public partial class Produse : Form
    {
        AdministrareProduse_FisierText adminProduse;
        public Produse()
        {
            string fisierProduse = ConfigurationManager.AppSettings["fisierProduse"];
            string locatieFisierSolutie = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string caleCompletaFisier = locatieFisierSolutie + "\\" + fisierProduse;
            adminProduse = new AdministrareProduse_FisierText(caleCompletaFisier);

            InitializeComponent();

            List<Produs> produse = adminProduse.GetProduse();
            AfisareProduseInControlDataGridView(produse);
        }
        private void AfisareProduseInControlDataGridView(List<Produs> produse)
        {
            dataGridProduse.DataSource = null;

            dataGridProduse.DataSource = produse;
        }
        private void buttonexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnMeniu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Meniu meniu = new Meniu();
            meniu.Show();
        }
        private void adaugarefisier_Click(object sender, EventArgs e)
        {
            int pret;
            Int32.TryParse(txtPret.Text, out pret);

            if (txtDenumireProdus.Text == string.Empty || txtDataExpirarii.Text == "" || txtPret.Text == "")
                MessageBox.Show("Introduceți datele produsului! ");
            else
            {
                Produs produsNou = new Produs(0, txtDenumireProdus.Text, pret, txtDataExpirarii.Text);
                if (ckbIgiena.Checked)
                    produsNou.categorie = Produs.Categorie.Igiena;
                if (ckbPanificatie.Checked)
                    produsNou.categorie = Produs.Categorie.Panificatie;
                if (ckbDulciuri.Checked)
                    produsNou.categorie = Produs.Categorie.Dulciuri;
                if (ckbRacoritoare.Checked)
                    produsNou.categorie = Produs.Categorie.Racoritoare;
                adminProduse.AddProdus(produsNou);
                MessageBox.Show("Produsul a fost adaugat cu succes");
                ResetareControale();
            }
        }
        private void ResetareControale()
        {
            txtDenumireProdus.Text = txtDataExpirarii.Text = txtPret.Text = null;

        }
        private void btnCautareProdus_Click(object sender, EventArgs e)
        {
            List<Produs> produse = adminProduse.GetProduse();
            ArrayList produseGasite = new ArrayList();

            if (txtDenumireProdus.Text != "")
            {

                foreach (Produs produs in produse)
                {
                    if (produs.denumire == txtDenumireProdus.Text)
                    {
                        produseGasite.Add(produs);
                    }
                }
                AfisareProduseInControlDataGridView(produseGasite.Cast<Produs>().ToList());
                ResetareControale();
            }
            else
                MessageBox.Show("Introduceți denumirea produsului! ");
        }
        private void btnStergereProdus_Click(object sender, EventArgs e)
        {
            List<Produs> produse = adminProduse.GetProduse();
            foreach (Produs produs in produse)
            {
                if (txtDenumireProdus.Text == produs.denumire)
                {
                    adminProduse.StergereProdus(produs);
                }
            }
            produse = adminProduse.GetProduse();
            AfisareProduseInControlDataGridView(produse.Cast<Produs>().ToList());
            ResetareControale();
        }
        private void buttonAfisare_Click_1(object sender, EventArgs e)
        {

            List<Produs> produse = adminProduse.GetProduse();
            AfisareProduseInControlDataGridView(produse.Cast<Produs>().ToList());
        }
    }
}
