using System;
using System.Collections.Generic; //enthält Listen
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using System.Net.Sockets;

namespace Kundenverwaltung
{
    internal class Program
    {
        public static string path = @"c:\prog\Kundenverwaltung.csv"; //dank @ nimmt er den string wörtlich
        public static string path2 = @"c:\prog\Kundenverwaltung2.csv"; //dank @ nimmt er den string wörtlich
        static char trennzeichen = ';';
        static List<Kunde> clients = new List<Kunde>();

        static void Main(string[] args)
        {
            string strMeldung, strWahl;
            strMeldung = "Treffen Sie eine Auswahl:\n\n";
            strMeldung += "(N) - Kundendaten neu anlegen\n";
            strMeldung += "(A) - Kundendaten speichern\n";
            strMeldung += "(B) - Kundendaten wiederherstellen\n";
            strMeldung += "(C) - Kundeneintrag korrigieren\n";
            strMeldung += "(D) - Kundeneintrag auf Anforderung löschen\n";
            strMeldung += "(E) - Kundeneintrag sortieren nach Nachname\n";
            strMeldung += "(F) - Kundeneintrag sortieren nach Postleitzahl\n";
            strMeldung += "(G) - Kundeneintrag sortieren nach Ort\n";
            strMeldung += "(H) - Kundeneintrag sortieren nach Geburtsdatum\n";
            Console.WriteLine(strMeldung);
            strWahl = Console.ReadLine().ToUpper();
            LeseDaten();
            if (strWahl == "N")
            {
                Console.Write("Neue Kundendaten anlegen");
                //Anweisungen für SchreibeDaten
                Console.WriteLine();
                NeuerKunde();
                SchreibeDaten();
                Console.ReadLine();
            }
            else if(strWahl == "E")
            {
                List<Kunde> ergebnis = clients;
                //ergebnis.Clear; nicht möglich da kein assignment-Befehl
                Kunde tempclient;
                //Sortierung auf der Konsole ausgeben lassen
                Console.WriteLine("Sortiere nach Kundennachname");
                for (int i = 0; i < ergebnis.Count - 1; i++)
                {
                    for (int j = 0; j < ergebnis.Count - 1; j++)
                    {
                        if (String.Compare(ergebnis[j + 1].Plz, ergebnis[j].Plz) > 0)
                        {
                            tempclient = ergebnis[j];
                            ergebnis[j] = ergebnis[j + 1];
                            ergebnis[j + 1] = tempclient;
                        }
                    }
                }
                foreach (Kunde kunde in ergebnis)
                {
                    Console.WriteLine(kunde.Kundennachname);
                }
            }
            else if (strWahl == "F")
            {
                List<Kunde> ergebnis = clients;
                //ergebnis.Clear; nicht möglich da kein assignment-Befehl
                Kunde tempclient;
                //Sortierung auf der Konsole ausgeben lassen
                Console.WriteLine("Sortiere nach PLZ");
                for (int i = 0; i < ergebnis.Count - 1; i++)
                {
                    for (int j = 0; j < ergebnis.Count - 1; j++)
                    {
                        if (String.Compare(ergebnis[j + 1].Plz, ergebnis[j].Plz)>0) 
                        {
                            tempclient = ergebnis[j];
                            ergebnis[j] = ergebnis[j + 1];
                            ergebnis[j + 1] = tempclient;
                        }
                    }
                }
                foreach (Kunde kunde in ergebnis)
                {
                    Console.WriteLine(kunde.Plz);
                }
            }
            else if (strWahl == "G")
            {
                List<Kunde> ergebnis = clients;
                //ergebnis.Clear; nicht möglich da kein assignment-Befehl
                Kunde tempclient;
                //Sortierung auf der Konsole ausgeben lassen
                Console.WriteLine("Sortiere nach Ort");
                for (int i = 0; i < ergebnis.Count - 1; i++)
                {
                    for (int j = 0; j < ergebnis.Count - 1; j++)
                    {
                        if (String.Compare(ergebnis[j + 1].Ort, ergebnis[j].Ort) > 0)
                        {
                            tempclient = ergebnis[j];
                            ergebnis[j] = ergebnis[j + 1];
                            ergebnis[j + 1] = tempclient;
                        }
                    }
                }
                foreach (Kunde kunde in ergebnis)
                {
                    Console.WriteLine(kunde.Ort);
                }
            }
            else if (strWahl == "H")
            {
                List<Kunde> ergebnis = clients;
                //ergebnis.Clear; nicht möglich da kein assignment-Befehl
                Kunde tempclient;
                //Sortierung auf der Konsole ausgeben lassen
                Console.WriteLine("Sortiere nach Geburtsdatum");
                for (int i = 0; i < ergebnis.Count - 1; i++)
                {
                    for (int j = 0; j < ergebnis.Count - 1; j++)
                    {
                        if (DateTime.Compare(ergebnis[j + 1].Geburtsdatum, ergebnis[j].Geburtsdatum) > 0)
                        {
                            tempclient = ergebnis[j];
                            ergebnis[j] = ergebnis[j + 1];
                            ergebnis[j + 1] = tempclient;
                        }
                    }
                }
                foreach (Kunde kunde in ergebnis)
                {
                    Console.WriteLine(kunde.Geburtsdatum);
                }
            }
            Console.WriteLine();
            Console.ReadLine();
        }


        private static void NeuerKunde()
        {
            //Kunde t_client = new Kunde(string t_kundennummer, string t_kundenvorname, string t_kundennachname, string t_strassenname, int t_hausnummer, int t_plz, string t_ort, string t_land, string t_telefonnummer, string t_mailadresse, int t_geburtsdatum);
            //Kunde t_client = new Kunde("1");
            Kunde t_client = new Kunde();
            Console.Write("Kundennummer: ");
            t_client.Kundennummer = Console.ReadLine();
            Console.Write("Kundenvorname: ");
            t_client.Kundenvorname = Console.ReadLine();
            Console.Write("Kundennachname: ");
            t_client.Kundennachname = Console.ReadLine();
            Console.Write("Strassenname: ");
            t_client.Strassenname = Console.ReadLine();
            Console.Write("Hausnummer: ");
            t_client.Hausnummer = Console.ReadLine();
            Console.Write("Postleitzahl: ");
            t_client.Plz = Console.ReadLine();
            Console.Write("Ort: ");
            t_client.Ort = Console.ReadLine();
            Console.Write("Land: ");
            t_client.Land = Console.ReadLine();
            Console.Write("Telefonnummer: ");
            t_client.Telefonnummer = Console.ReadLine();
            Console.Write("Mailadresse: ");
            t_client.Mailadresse = Console.ReadLine();
            Console.Write("Geburtsdatum: ");
            t_client.Geburtsdatum = DateTime.Parse(Console.ReadLine());
            clients.Add(t_client);
        }

        static void LeseDaten()
        {
            string[] zeilen, felder;
            Kunde t_kunde;
            clients.Clear();
            try
            {
                zeilen = File.ReadAllLines(path);
                foreach(var zeile in zeilen)
                {
                    felder = zeile.Split(trennzeichen);
                    t_kunde = new Kunde();
                    t_kunde.Kundennummer=felder[0];
                    t_kunde.Kundenvorname = felder[1];
                    t_kunde.Kundennachname = felder[2];
                    t_kunde.Strassenname = felder[3];
                    t_kunde.Hausnummer = felder[4];
                    t_kunde.Plz = felder[5];
                    t_kunde.Ort = felder[6];
                    t_kunde.Land = felder[7];
                    t_kunde.Telefonnummer = felder[8];
                    t_kunde.Mailadresse = felder[9];
                    t_kunde.Geburtsdatum = DateTime.Parse(felder[10]);
                    clients.Add(t_kunde);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }


        static void SchreibeDaten()
        {
            string[] zeilen = new string[clients.Count]; //Erzeuge Array von der Laenge der Liste
            for (int i = 0; i < zeilen.Length; i++)
            {
                zeilen[i] = clients[i].Kundennummer;
            }
            try
            {
                File.WriteAllLines(path, zeilen);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}


