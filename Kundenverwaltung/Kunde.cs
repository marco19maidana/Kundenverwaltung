using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kundenverwaltung
{
    internal class Kunde
    {
        #region Felder
        //Attribute der Kundenklasse
        private string _kundennummer;//alphanumerisch daher string
        private string _kundenvorname;
        private string _kundennachname;
        private string _strassenname;
        private string _hausnummer;
        private string _plz;
        private string _ort;
        private string _land;
        private string _telefonnummer;//alphanumerisch daher string
        private string _mailadresse;
        private DateTime _geburtsdatum;
        private List<Kunde> _kunde;
        private List<Adresse>_adressen;
        #endregion

        #region Eigenschaften
        public string Kundennummer
        {
            get { return _kundennummer; }
            set { _kundennummer = value; }
        }

        public string Kundenvorname
        {
            get { return _kundenvorname; }
            set { _kundenvorname = value; }
        }

        public string Kundennachname
        {
            get { return _kundennachname; }
            set { _kundennachname = value; }
        }

        public string Strassenname
        {
            get { return _strassenname; }
            set {_strassenname = value;}
        }

        public string Hausnummer
        {
            get { return _hausnummer; }
            set {_hausnummer = value;}
        }

        public string Plz
        {
            get { return _plz; }
            set {_plz = value;}
        }

        public string Ort
        {
            get { return _ort; }
            set {_ort = value;}
        }

        public string Land
        {
            get { return _land; }
            set{ _land = value;}
        }

        public string Telefonnummer
        {
            get { return _telefonnummer; }
            set{ _telefonnummer = value; }
        }

        public string Mailadresse
        {
            get { return _mailadresse; }
            set {_mailadresse = value;}
        }

        public DateTime Geburtsdatum
        {
            get { return _geburtsdatum; }
            set { _geburtsdatum = value; }
        }

        private List<Kunde> kunde
        {
            get { return _kunde; }
            set { _kunde = value; }
        }
        #endregion

        #region Konstruktor
        //Expliziter, parametrisierter Konstruktor
        /*
        public Kunde(string t_kundennummer, string t_kundenvorname, string t_kundennachname, string t_strassenname, string t_hausnummer, string t_plz, string t_ort, string t_land, string t_telefonnummer, string t_mailadresse, int t_geburtsdatum) 
        {
            Kundennummer = t_kundennummer;
            Kundenvorname = t_kundenvorname;
            Kundennachname = t_kundennachname;
            Strassenname = t_strassenname;
            Hausnummer = t_hausnummer;
            PLz = t_plz;
            Ort = t_ort;
            Land = t_land;
            Telefonnummer = t_telefonnummer;
            Mailadresse = t_mailadresse;
            Geburtsdatum = t_geburtsdatum;
        }        */
        public Kunde(string t_kundennummer)
        {
            Kundennummer = t_kundennummer;
        }

        public Kunde()//Standardkonstruktor (implizit, parameterlos)
        {
 
        }
        #endregion

        #region Methoden

        #endregion
    }
}
