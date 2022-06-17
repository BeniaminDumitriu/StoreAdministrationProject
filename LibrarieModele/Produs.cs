using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static NivelStocareDate.Enumerari;

namespace LibrarieModele
{
    public class Produs
    {
        [Flags]
        public enum Categorie
        {
            Igiena = 1,
            Panificatie = 2,
            Dulciuri = 3,
            Racoritoare=4

        }
        private const char SEPARATOR_PRINCIPAL_FISIER = ',';

        public int idProdus { get; set; }
        public string denumire { get; set; }
        public int pret { get; set; }
        public string data_expirarii { get; set; }
        public Categorie categorie { get; set; }

        private const int IDPRODUS = 0;
        private const int DENUMIRE = 1; 
        private const int PRET = 2;
        private const int DATA_EXPIRARII = 3;
        private const int CATEGORIE = 4;

        public Produs()
        {
            denumire = data_expirarii = string.Empty;
            idProdus = pret =  0;
        }
        public Produs(string denumire, int pret)
        {
            this.denumire = denumire;
            this.pret = pret;
        }
       
        public Produs(int idProdus, string denumire, int pret, string data_expirarii)
        {
            this.idProdus = idProdus;
            this.denumire = denumire;
            this.pret = pret;
            this.data_expirarii = data_expirarii;
        }

        public Produs(string linieFisier)
        {
            var dateFisier = linieFisier.Split(SEPARATOR_PRINCIPAL_FISIER);

            idProdus = Convert.ToInt32(dateFisier[IDPRODUS]);
            denumire = dateFisier[DENUMIRE];
            pret = Convert.ToInt32(dateFisier[PRET]);
            data_expirarii = dateFisier[DATA_EXPIRARII];
            categorie = (Categorie)Enum.Parse(typeof(Categorie), dateFisier[CATEGORIE]);
        }

        public string ConversieLaSir_PentruFisier()
        {
            string obiectProdusPentruFisier = string.Format("{1}{0}{2}{0}{3}{0}{4}{0}{5}{0}",
                SEPARATOR_PRINCIPAL_FISIER,
                idProdus.ToString(),
                (denumire ?? " NECUNOSCUT "),
                pret.ToString(),
                data_expirarii,
                categorie);

            return obiectProdusPentruFisier;
        }

        public void SetIdProdus(int idProdus)
        {
            this.idProdus = idProdus;
        }

        public int GetIdProdus()
        {
            return idProdus;
        }
       
        public string GetDenumireProdus()
        {
            return denumire;
        }
        
        public int GetPret()
        {
            return pret;
        }
        
        public string GetDataExpirarii()
        {
            return data_expirarii;
        }
    }
}
