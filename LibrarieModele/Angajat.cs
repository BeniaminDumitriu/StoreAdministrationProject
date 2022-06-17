using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarieModele
{
    public class Angajat
    {
        private const char SEPARATOR_PRINCIPAL_FISIER = ';';

        public int idAngajat { get; set; }
        public string nume { get; set; }
        public string prenume { get; set; }
        public int varsta{ get; set; }
        public string job { get; set; }

        private const int IDANGAJAT = 0;
        private const int NUME = 1;
        private const int PRENUME = 2;
        private const int VARSTA = 3;
        private const int JOB = 4;

        public Angajat()
        {
            nume = prenume = job = string.Empty;
            idAngajat = varsta = 0;
        }
        public Angajat(string nume,string prenume)
        {
            this.nume = nume;
            this.prenume = prenume;
        }

        public Angajat(int idAngajat, string nume, string prenume, int varsta,string job)
        {
            this.idAngajat = idAngajat;
            this.nume = nume;
            this.prenume = prenume;
            this.varsta = varsta;
            this.job = job;
        }

        public Angajat(string linieFisier)
        {
            var dateFisier = linieFisier.Split(SEPARATOR_PRINCIPAL_FISIER);

            idAngajat = Convert.ToInt32(dateFisier[IDANGAJAT]);
            nume = dateFisier[NUME];
            prenume = dateFisier[PRENUME];
            varsta = Convert.ToInt32(dateFisier[VARSTA]);
            job = dateFisier[JOB];
        }

        public string ConversieLaSir_PentruFisier()
        {
            string obiectProdusPentruFisier = string.Format("{1}{0}{2}{0}{3}{0}{4}{0}{5}{0}",
                SEPARATOR_PRINCIPAL_FISIER,
                idAngajat.ToString(),
                (nume ?? " NECUNOSCUT "),
                prenume,
                varsta.ToString(),
                job);
                

            return obiectProdusPentruFisier;
        }

        public void SetIdAngajat(int idAngajat)
        {
            this.idAngajat = idAngajat;
        }
        public void SetVarsta(string varsta)
        {
            this.varsta = Convert.ToInt32(varsta);
        }
        public int GetIdAngajat()
        {
            return idAngajat;
        }

        public string GetNumeAngajat()
        {
            return nume;
        }

        public string GetPrenumeAngajat()
        {
            return prenume;
        }

        public int GetVarsta()
        {
            return varsta;
        }

        
    }
}
