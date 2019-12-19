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
using WindowsFormsApp1.Ext;

namespace WindowsFormsApp1
{

    public partial class Fahrplan : Form
    {
        Transport m_transport = new Transport();


 
        public Fahrplan()
        {
            InitializeComponent();
        }
        void SuggestionList(ref ComboBox comboBox)
        {
            string searchText = comboBox.Text;

            if (String.IsNullOrEmpty(searchText)) return;

            var stationList = m_transport.GetStations(searchText).StationList;
            if (stationList.Count <= 0) return;

            List<String> stationNames = new List<String>();
            foreach (Station station in stationList)
                stationNames.Add(station.Name);

            comboBox.SafeClearItems();
            comboBox.Items.AddRange(stationNames.ToArray());
        }




        private void suchen_Click(object sender, EventArgs e)

        {
            

            
        }



        private void verbindungen_Click(object sender, EventArgs e)
        {

        }

        private void Fahrplan_Load(object sender, EventArgs e)
        {
            standort.Select();
            datum.Value = DateTime.Now;
        }

        private void wechsel_Click(object sender, EventArgs e)
        {
            string altesVon = standort.Text;
            standort.Text = zielort.Text;
            zielort.Text = altesVon;
            standort.Select();
        }





        private void standort_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void standort_KeyPress(object sender, KeyPressEventArgs e)
        {
            standort.DroppedDown = true;
            SuggestionList(ref standort);
        }

        private void zielort_KeyDown(object sender, KeyEventArgs e)
        {
            zielort.DroppedDown = true;
            SuggestionList(ref zielort);
        }
    }

    }

