using System.Collections.Generic;

namespace VelosMarseille
{
    public class Carte
    {
        private List<Station> mesStations;
        public Carte()
        {
            this.mesStations = new List<Station>();
        }
        public void ajouteStation(string numero, string adresse, bool ouvert, bool bonus)
        {
            Station s = new Station(numero, adresse, ouvert, bonus);
            this.mesStations.Add(s);
        }
        public Station getLaStation(int i)
        {
            return this.mesStations[i];
        }
        public int nbStations()
        {
            return this.mesStations.Count;
        }
    }
}