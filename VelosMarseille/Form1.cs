using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VelosMarseille
{
    public partial class Form1 : Form
    {
        private List<Station> lesStations;
        private Carte laCarte;
        private string[] lesInfos;

        public Form1()
        {
            InitializeComponent();
            this.laCarte = Passerelle.getCarte();
            this.lesStations = new List<Station>();
        }
        private void setLesStations(string secteur)
        {
            this.lesStations.Clear();
            // Ne pas oublier de vider la liste
            for(int i = 0; i < this.laCarte.nbStations(); i++)
            {
                Station st =this.laCarte.getLaStation(i);
                if (st.Adresse == secteur)
                    this.lesStations.Add(st);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}