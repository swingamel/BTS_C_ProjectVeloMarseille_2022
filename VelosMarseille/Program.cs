using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VelosMarseille
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        /*static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            //Test Carte 1
            Station s1 = new Station("1001", "CANEBIERE REINE ELISABETH - CANEBIERE ANGLE REINE ELISABETH", true, false);
            Station s2 = new Station("5103", "RUE GEORGES - 28 RUE GEORGES", true, true);
            Debug.WriteLine(s1.Secteur);
            Debug.WriteLine(s2.Secteur);
        }*/
        /*
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            //Test Carte 2
            Carte c = new Carte();
            c.ajouteStation("1001", "CANEBIERE REINE ELISABETH - CANEBIERE ANGLE REINE ELISABETH", true, false);
            c.ajouteStation("5103", "RUE GEORGES - 28 RUE GEORGES", true, true);
            Debug.WriteLine(c.getLaStation(0).Secteur);
            Debug.WriteLine(c.getLaStation(0).Adresse);
            Debug.WriteLine(c.getLaStation(1).Secteur);
            Debug.WriteLine(c.getLaStation(1).Adresse);
        }*/
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            //Test Carte 3
            Carte c = Passerelle.getCarte();
            Debug.WriteLine(c.getLaStation(1).Numero);
        }
    }
}