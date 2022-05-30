using System;

namespace VelosMarseille
{
    public class Station
    {
        public Station(string numero, string adresse, bool ouvert, bool bonus)
        {
            this.numero = numero;
            this.adresse = adresse;
            if (this.Numero.Length == 4)
            {
                Convert.ToInt32(this.numero);
                this.secteur = this.numero.Substring(0, 1);
            }
            this.ouvert = ouvert;
            this.bonus = bonus;
        }
        //Champs
        private string numero;
        private string secteur;
        private string adresse;
        private bool ouvert;
        private bool bonus;
        //Méthode get
        public string Numero
        {
            get
            {
                return this.numero;
            }
        }
        public string Secteur
        {
            get
            {
                return this.secteur;
            }
        }
        public string Adresse
        {
            get
            {
                return this.adresse;
            }
        }
        public bool Ouvert
        {
            get
            {
                return this.ouvert;
            }
        }
        public bool Bonus
        {
            get
            {
                return this.bonus;
            }
        }
    }
}