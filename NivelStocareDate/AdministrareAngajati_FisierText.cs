using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using LibrarieModele;
using System.Collections;

namespace NivelStocareDate
{
    public class AdministrareAngajati_FisierText
    {
        private const int NR_MAX_Angajati = 50;
        private const int ID_PRIMUL_ANGAJAT = 1;
        private const int INCREMENT = 1;
        private string numeFisier;

        public AdministrareAngajati_FisierText(string numeFisier)
        {
            this.numeFisier = numeFisier;

            Stream streamFisierText = File.Open(numeFisier, FileMode.OpenOrCreate);
            streamFisierText.Close();
        }

        public List<Angajat> GetAngajati()
        {
            ArrayList angajati = new ArrayList();

            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;

                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    Angajat angajat = new Angajat(linieFisier);
                    angajati.Add(angajat);
                }
            }

            return angajati.Cast<Angajat>().ToList();
        }

        public void AddAngajat(Angajat angajatNou)
        {
            angajatNou.idAngajat = GetIdAngajat();

            using (StreamWriter streamWriterFisierText = new StreamWriter(numeFisier, true))
            {
                streamWriterFisierText.WriteLine(angajatNou.ConversieLaSir_PentruFisier());
            }
        }
        public void StergereAngajat(Angajat angajatSters)
        {
            List<Angajat> angajati = GetAngajati();

            angajati.RemoveAt(angajatSters.GetIdAngajat()-1);

            int id = 1;

            using (StreamWriter streamWriterFisierText = new StreamWriter(numeFisier, false))
            {
                foreach (Angajat angajat in angajati)
                {
                    Angajat angajatPentruScrisInFisier = angajat;

                    angajatPentruScrisInFisier.SetIdAngajat(id);

                    id++;

                    streamWriterFisierText.WriteLine(angajatPentruScrisInFisier.ConversieLaSir_PentruFisier());
                }
            }
        }
        private int GetIdAngajat()
        {
            int IdAngajat = ID_PRIMUL_ANGAJAT;
            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    Angajat angajat = new Angajat(linieFisier);
                    IdAngajat = angajat.idAngajat + INCREMENT;
                }
            }

            return IdAngajat;
        }
    }
}
