using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransport;


namespace WindowsFormsApp1
{

    public partial class Fahrplan : Form
    {
        Transport m_transport = new Transport();


 
        public Fahrplan()
        {
            InitializeComponent();
        }

        private void Stationen(ref TextBox textBox)
        {

            if (textBox.TextLength >= 3)
            {
                var stationsListe = m_transport.GetStations(textBox.Text).StationList;
                foreach (Station station in stationsListe)
                {
                    textBox.AutoCompleteCustomSource.Add(station.Name);

                }


            }

        }


        private void suchen_Click(object sender, EventArgs e)

        { }



        private void verbindungen_Click(object sender, EventArgs e)
        {

        }

        private void Fahrplan_Load(object sender, EventArgs e)
        {

        }

        private void wechsel_Click(object sender, EventArgs e)
        {
            
        }

        private void standort_TextChanged(object sender, EventArgs e)
        {
            Stationen(ref standort);
        }

        private void zielort_TextChanged(object sender, EventArgs e)
        {
            Stationen(ref zielort);

        }
    }

    }

