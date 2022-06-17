using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using LibrarieModele;

namespace NivelStocareDate
{
    public class AdministrareProduse_FisierText
    {
        private const int NR_MAX_PRODUSE = 50;
        private const int ID_PRIMUL_Produs = 1;
        private const int INCREMENT = 1;
        private string numeFisier;

        public AdministrareProduse_FisierText(string numeFisier)
        {
            this.numeFisier = numeFisier;

            Stream streamFisierText = File.Open(numeFisier, FileMode.OpenOrCreate);
            streamFisierText.Close();
        }

        public List<Produs> GetProduse()
        {
            ArrayList produse = new ArrayList();

            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;

                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    Produs produs = new Produs(linieFisier);
                    produse.Add(produs);
                }
            }

            return produse.Cast<Produs>().ToList();
        }

        public void AddProdus(Produs produsNou)
        {
            produsNou.idProdus = GetIdProdus();
            using (StreamWriter streamWriterFisierText = new StreamWriter(numeFisier, true))
            {
                streamWriterFisierText.WriteLine(produsNou.ConversieLaSir_PentruFisier());
            }
        }
        private int GetIdProdus()
        {
            int idProdus = ID_PRIMUL_Produs;
            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    Produs produs = new Produs(linieFisier);
                    idProdus = produs.idProdus + INCREMENT;
                }
            }

            return idProdus;
        }
        public void StergereProdus(Produs produsSters)
        {
            List<Produs> produse = GetProduse();

            produse.RemoveAt(produsSters.GetIdProdus() - 1);

            int id = 1;

            using (StreamWriter streamWriterFisierText = new StreamWriter(numeFisier, false))
            {
                foreach (Produs produs in produse)
                {
                    Produs produsPentruScrisInFisier = produs;

                    produsPentruScrisInFisier.SetIdProdus(id);

                    id++;

                    streamWriterFisierText.WriteLine(produsPentruScrisInFisier.ConversieLaSir_PentruFisier());
                }
            }
        }
    }
}
