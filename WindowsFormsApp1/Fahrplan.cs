using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            //making out of text time 
            InitializeComponent();
            time.Text = DateTime.Now.ToString("HH:mm");
        }
        public bool Map(string station)
        {
            if (string.IsNullOrEmpty(station)) return false;

            Coordinate statoinCoord = m_transport.GetStations(station).StationList.ElementAt(0).Coordinate;
            double x = statoinCoord.XCoordinate;
            double y = statoinCoord.YCoordinate;
            String b = Convert.ToString(x).Replace(',', '.');
            String a = Convert.ToString(y).Replace(',', '.');


            System.Diagnostics.Process.Start("http://www.google.ch/maps/place/" + b + "," + a);
            return true;
        }

        private ListViewItem ShowConnections(Connection connection)
        {
            string[] connections = { connection.From.Departure.ToString().Substring(0, 10), connection.From.Departure.ToString().Substring(11, 5), connection.From.Station.Name, connection.To.Station.Name, connection.To.Arrival.ToString().Substring(11, 5), connection.Duration.Substring(3, 5), connection.From.Platform };
            return new ListViewItem(connections);
        }

        // Map Coordinates
        private string Xyz(string Station)
        {
            var xyz = m_transport.GetStations(Station).StationList.FirstOrDefault(x => Equals(x.Name, Station));
            if (xyz != null)
            {
                string x = Convert.ToString(xyz.Coordinate.XCoordinate);
                string y = Convert.ToString(xyz.Coordinate.YCoordinate);
                string amalgamatedCoordinates = x + "/" + y;
                return amalgamatedCoordinates;
            }
            else
                return "ERROR";
        }



        #region Loscht
        void loscht()
        {

        }
        #endregion Loscht

        void fill()
        {
            int width = (verbindungen.Width / 4);
            verbindungen.Columns.Add("Datum", width);
            verbindungen.Columns.Add("Zeit", width);
            verbindungen.Columns.Add("Von", width);
            verbindungen.Columns.Add("Nach", width);
        }

        // validating if time is correct
        private bool CheckTime(TextBox textBox)
        {
            string CheckingTime = textBox.Text;
            bool returnValue = true;
            Match match = Regex.Match(CheckingTime, @"^(0[0-9]|1[0-9]|2[0-3]):[0-5][0-9]$", RegexOptions.IgnoreCase);

            if (!match.Success)
            {
                returnValue = false;
            }
            return returnValue;
        }

        private bool CheckStations(ComboBox comboBox)
        {
            bool returnValue = true;
            if (comboBox.Text.Length <= 0 || comboBox.Text == null)
            {
                returnValue = false;
            }
            return returnValue;
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
            this.verbindungen.Items.Clear();
            string from = this.standort.Text;
            string to = this.zielort.Text;


            if (CheckStations(standort) && CheckStations(zielort) && CheckTime(time))
            {

                string Date = datum.Value.Year + "-" + datum.Value.Month + "-" + datum.Value.Day;

                foreach (global::SwissTransport.Connection connection in m_transport.GetConnections(from, to, Date, time.Text).ConnectionList)
                {
                    verbindungen.Items.Add(ShowConnections(connection));
                }
            }
            if (!CheckTime(time))
            {
                MessageBox.Show("Bitte zeit überprüfen");
            }
            if (!CheckStations(standort))
            {
                MessageBox.Show("Bitte Standort überprüfen");
            }
            if (!CheckStations(zielort))
            {
                MessageBox.Show("Bitte zielort überprüfen");
            }
        }







        private void verbindungen_Click(object sender, EventArgs e)
        {



        }

        private void Fahrplan_Load(object sender, EventArgs e)
        {
            fill();
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



        private void verbindungen_SelectedIndexChanged(object sender, EventArgs e)
        {


        }



        private void time_TextChanged(object sender, EventArgs e)
        {

        }


        // Map Buttons

        private void buttonmap(object sender, EventArgs e)
        {
            Map(standort.Text);
        }

        private void buttonmap2(object sender, EventArgs e)
        {
            Map(zielort.Text);
        }
    }

}

