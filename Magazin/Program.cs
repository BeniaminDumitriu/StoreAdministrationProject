using System;
using System.IO;
using System.Configuration;
using NivelStocareDate;
using LibrarieModele;

namespace Magazin
{
    class Program
    {
        //enumeratie
        [Flags]
        public enum CategoriiProduse
        {
            Igiena = 1,
            Alimente = 2,
            Bucatarie = 3,
            Dulciuri = 4,
            Jucarii = 5
        };
        public const CategoriiProduse IGIENA = CategoriiProduse.Igiena;
        public const CategoriiProduse ALIMENTE = CategoriiProduse.Alimente;
        public const CategoriiProduse BUCATARIE = CategoriiProduse.Bucatarie;
        public const CategoriiProduse DULCIURI = CategoriiProduse.Dulciuri;
        public const CategoriiProduse JUCARII = CategoriiProduse.Jucarii;

        public enum JoburiAngajati
        {
            Director = 1,
            Manager = 2,
            Casier = 3,
            Ingrijitor = 4
        };
        public const JoburiAngajati DIRECTOR = JoburiAngajati.Director;
        public const JoburiAngajati MANAGER = JoburiAngajati.Manager;
        public const JoburiAngajati CASIER = JoburiAngajati.Casier;
        public const JoburiAngajati INGRIJITOR = JoburiAngajati.Ingrijitor;
        static void Main(string[] args)
        {




            //produse fisier
            string fisierProdus = ConfigurationManager.AppSettings.Get("fisierProduse");
            AdministrareProduse_FisierText adminProduse = new AdministrareProduse_FisierText(fisierProdus);
            Produs produsNou = new Produs();

            int nrProduse;
            adminProduse.GetProduse(out nrProduse);

            //angajat
            string fisierAngajati = ConfigurationManager.AppSettings["fisierAngajati"];
            string locatieFisierSolutie = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string caleCompletaFisier = locatieFisierSolutie + "\\" + fisierAngajati;
            AdministrareAngajati_FisierText adminAngajat = new AdministrareAngajati_FisierText(caleCompletaFisier);
            Angajat angajatNou = new Angajat();

            int nrAngajati;
            adminAngajat.GetAngajati(out nrAngajati);


            string optiune;
            do
            {
                //produse
                Console.WriteLine("                 CITIRE DATE DE LA TASTATURA");
                Console.WriteLine("C. Citire informatii produs de la tastatura");
                Console.WriteLine("J. Citire informatii angajat de la tastatura");
                Console.WriteLine();
                Console.WriteLine("                 CAUTARE DUPA DENUMIRE PRODUS/NUME ANGAJAT");
                Console.WriteLine("A. Cautare dupa denumirea produsului");
                Console.WriteLine("I. Cautarea dupa numele angajatului");
                Console.WriteLine();
                Console.WriteLine("                 AFISARE PRODUSE/ANGAJATI");
                Console.WriteLine("F. Afisare produse din fisier");
                Console.WriteLine("K. Afisare angajati din fisier");
                Console.WriteLine();
                Console.WriteLine("                 SALVARE PRODUSE/ANGAJATI IN FISIER");
                Console.WriteLine("S. Salvare produs in fisier");
                Console.WriteLine("L. Salvare angajat in fisier");
                Console.WriteLine();
                Console.WriteLine("                 IESIRE PROGRAM");
                Console.WriteLine("X. Inchidere program");
                Console.WriteLine();
                Console.Write("Alegeti o optiune: ");
                optiune = Console.ReadLine();
                Console.Clear();
                switch (optiune.ToUpper())
                {
                    case "C":
                        produsNou = CitireProdusTastatura();
                        Console.WriteLine();
                        Console.WriteLine("Press any key to continue..");
                        Console.Clear();
                        break;
                    case "J":
                        angajatNou = CitireAngajatTastatura();
                        Console.WriteLine();
                        Console.WriteLine("Press any key to continue..");
                        Console.Clear();
                        break;

                    case "A":
                        Console.Write("Dati denumirea produsului cautat: ");
                        string produs_cautat = Console.ReadLine();
                        Produs[] lista = adminProduse.GetProduse(out nrProduse);
                        cautareProdusDenumire(lista, nrProduse, produs_cautat);
                        Console.WriteLine();
                        Console.WriteLine("Press any key to continue..");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "I":
                        Console.Write("Dati numele angajatului cautat: ");
                        string angajat_cautat = Console.ReadLine();

                        Angajat[] lista_angajati = adminAngajat.GetAngajati(out nrAngajati);
                        CautareAngajatNume(lista_angajati, nrAngajati, angajat_cautat);
                        Console.WriteLine();
                        Console.WriteLine("Press any key to continue..");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "F":
                        Produs[] lista_produse = adminProduse.GetProduse(out nrProduse);
                        AfisareProduse(lista_produse, nrProduse);

                        Console.WriteLine();
                        Console.WriteLine("Press any key to continue..");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "K":
                        Angajat[] lista1 = adminAngajat.GetAngajati(out nrAngajati);
                        AfisareAngajati(lista1, nrAngajati);
                        Console.WriteLine();
                        Console.WriteLine("Press any key to continue..");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "S":
                        int idProdus = nrProduse + 1;
                        produsNou.SetIdProdus(idProdus);
                        adminProduse.AddProdus(produsNou);
                        nrProduse = nrProduse + 1;
                        Console.WriteLine("Produs salvat cu succes");
                        Console.WriteLine();
                        Console.WriteLine("Press any key to continue..");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "L":
                        int idAngajat = nrAngajati + 1;
                        angajatNou.SetIdAngajat(idAngajat);
                        adminAngajat.AddAngajat(angajatNou);

                        nrAngajati = nrAngajati + 1;

                        Console.WriteLine("Angajat salvat cu succes");
                        Console.WriteLine();
                        Console.WriteLine("Press any key to continue..");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "X":
                        return;
                    default:
                        Console.WriteLine("Alegeti o optiune valida!\n");
                        Console.WriteLine();
                        Console.WriteLine("Press any key to continue..");
                        break;
                }

            }
            while (optiune.ToUpper() != "X");

            Console.ReadLine();
        }
        public static void cautareProdusDenumire(Produs[] lista, int nrProduse, string produs_cautat)
        {
            bool ok = false;
            for (int contor = 0; contor < nrProduse; contor++)
            {
                if (lista[contor].GetDenumireProdus() == produs_cautat)
                {
                    AfisareProdus(lista[contor]);
                    ok = true;
                }
            }
            if (ok == false)
                Console.WriteLine("Produs inexistent");
        }
        //cautare angajat dupa nume
        public static void CautareAngajatNume(Angajat[] lista_angajati, int nrAngajati, string angajat_cautat)
        {
            bool ok = false;
            for (int contor = 0; contor < nrAngajati; contor++)
            {
                if (lista_angajati[contor].GetNumeAngajat() == angajat_cautat)
                {
                    AfisareAngajat(lista_angajati[contor]);
                    ok = true;
                }
            }
            if (ok == false)
                Console.WriteLine("Produs inexistent");
        }


        public static void AfisareProdus(Produs produs)
        {
            string infoProdus = string.Format("Produsul {1} are id-ul #{0} si pretul de {2} lei, data expirarii {3} si face parte din categoria {4}.",
                   produs.idProdus,
                   produs.denumire,
                   produs.pret,
                   produs.data_expirarii,
                   produs.categorie);


            Console.WriteLine(infoProdus);
        }
        //afisare angajat
        public static void AfisareAngajat(Angajat angajat)
        {
            string infoAngajat = string.Format("{1} {2} cu id-ul #{0} are varsta de {3} ani si jobul de {4}.",
                   angajat.idAngajat,
                   angajat.nume,
                   angajat.prenume,
                   angajat.varsta,
                   angajat.job);

            Console.WriteLine(infoAngajat);
        }


        public static void AfisareProduse(Produs[] lista_produse, int nrProduse)
        {
            Console.WriteLine("Produsele sunt:");
            for (int contor = 0; contor < nrProduse; contor++)
            {
                AfisareProdus(lista_produse[contor]);
            }
        }
        //afisare angajati
        public static void AfisareAngajati(Angajat[] lista_angajati, int nrAngajati)
        {
            Console.WriteLine("Angajatii sunt:");
            for (int contor = 0; contor < nrAngajati; contor++)
            {
                AfisareAngajat(lista_angajati[contor]);
            }
        }


        public static Produs CitireProdusTastatura()
        {
            Console.Write("Introduceti denumirea: ");
            string denumire = Console.ReadLine();

            Console.Write("Introduceti pretul: ");
            int pret = Convert.ToInt32(Console.ReadLine());

            Console.Write("Introduceti data expirarii (dd/mm/yyyy): ");
            string data_expirarii = Console.ReadLine();

            Console.Write("Introduceti categoria din care face produsul dupa urmatoarele criterii:");
            Console.WriteLine("Igiena-1");
            Console.WriteLine("Alimentare-2");
            Console.WriteLine("Bucatarie-3");
            Console.WriteLine("Dulciuri-4");
            Console.WriteLine("Jucarii-5");
            Console.WriteLine();
            Console.WriteLine("Categoria aleasa este: ");
            int categorie = Convert.ToInt32(Console.ReadLine());
            if (categorie == (int)IGIENA)
            {
                Produs produs = new Produs(0, denumire, pret, data_expirarii, IGIENA.ToString());
                return produs;
            };
            if (categorie == (int)ALIMENTE)
            {
                Produs produs = new Produs(0, denumire, pret, data_expirarii, ALIMENTE.ToString());
                return produs;
            };
            if (categorie == (int)BUCATARIE)
            {
                Produs produs = new Produs(0, denumire, pret, data_expirarii, BUCATARIE.ToString());
                return produs;
            };
            if (categorie == (int)DULCIURI)
            {
                Produs produs = new Produs(0, denumire, pret, data_expirarii, DULCIURI.ToString());
                return produs;
            };
            if (categorie == (int)JUCARII)
            {
                Produs produs = new Produs(0, denumire, pret, data_expirarii, JUCARII.ToString());
                return produs;
            };
            Produs produsGol = new Produs();
            return produsGol;
        }

        public static Angajat CitireAngajatTastatura()
        {
            Console.Write("Introduceti numele: ");
            string nume = Console.ReadLine();
            Console.Write("Introduceti prenumele: ");
            string prenume = Console.ReadLine();
            Console.Write("Introduceti varsta: ");
            int varsta = Convert.ToInt32(Console.ReadLine());

            Console.Write("Introduceti cifra dupa jobul angajatului:");
            Console.WriteLine("Director-1");
            Console.WriteLine("Manager-2");
            Console.WriteLine("Casier-3");
            Console.WriteLine("Ingrijitor-4");
            Console.WriteLine();
            Console.WriteLine("Jobul ales este: ");
            int job = Convert.ToInt32(Console.ReadLine());
            if (job == (int)DIRECTOR)
            {
                Angajat angajat = new Angajat(0, nume, prenume, varsta, DIRECTOR.ToString());
                return angajat;
            };
            if (job == (int)MANAGER)
            {
                Angajat angajat = new Angajat(0, nume, prenume, varsta, MANAGER.ToString());
                return angajat;
            };
            if (job == (int)CASIER)
            {
                Angajat angajat = new Angajat(0, nume, prenume, varsta, CASIER.ToString());
                return angajat;
            };
            if (job == (int)INGRIJITOR)
            {
                Angajat angajat = new Angajat(0, nume, prenume, varsta, INGRIJITOR.ToString());
                return angajat;
            };
            Angajat angajatFaraJob = new Angajat();
            return angajatFaraJob;
        }

    }
}