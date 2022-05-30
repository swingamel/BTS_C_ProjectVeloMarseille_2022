using System;
using System.IO;
using System.Net;
using System.Xml;

namespace VelosMarseille
{
    public class Passerelle
    {
        private static string urlCarto = "http://www.levelo-mpm.fr/service/carto";
        private static string urlDispo = "http://www.levelo-mpm.fr/service/stationdetails/marseille/";

        public static Carte getCarte()
        {
            try
            {
                HttpWebRequest requete = (HttpWebRequest)WebRequest.Create(urlCarto);
                requete.Method = WebRequestMethods.Http.Get;
                WebResponse rep = requete.GetResponse();
                StreamReader sr = new StreamReader(rep.GetResponseStream());
                XmlReader xml = XmlReader.Create(sr);
                // A compléter
                Carte c = new Carte();
                xml.ReadToFollowing("marker");
                do
                {
                    // A compléter
                    // 1. Extraire chaque valeur des attributs number, fullAddress, open et bonus
                    // XmlElement.GetAttribute Method (String) Returns the value for the attribute with the specified name.
                    string num = xml.GetAttribute("number");
                    string adr = xml.GetAttribute("fullAddress");
                    string open = xml.GetAttribute("open");
                    string bonus = xml.GetAttribute("bonus");
                    bool s = (open == "1");
                    bool b = (bonus == "1");
                    // 2. Ajouter la station à la carte
                    c.ajouteStation(num, adr, s, b);
                }
                while (xml.ReadToNextSibling("marker"));
                // A compléter
                return c;
                
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
                return null;
            }
        }
    }
}