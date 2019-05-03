using SwissTransport;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwissTransportGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Transport t = new Transport();

        //Methode um eine Station in der "Startstation" zu suchen
        private void StationSuchen(string Stationsname, ListBox listBoxName)
        {
            listBoxName.Items.Clear();

            Stations myStations = t.GetStations(Stationsname);

            foreach(Station station in myStations.StationList)
            {
                try
                {
                    StationListViewItem item = new StationListViewItem(station);
                    listBoxName.Items.Add(item);
                }
                catch
                {

                }
            }
        }

        private void txtStartstation_TextChanged(object sender, EventArgs e)
        {
            StationSuchen(txtStartstation.Text, lbStartstation);
        }

        private void txtZielstation_TextChanged(object sender, EventArgs e)
        {
            StationSuchen(txtZielstation.Text, lbZielstation);
        }

        private void txtBeliebigeStation_TextChanged(object sender, EventArgs e)
        {
            StationSuchen(txtBeliebigeStation.Text, lbBeliebigeStation);
        }

        private void StationWaehlen(TextBox Textbox, ListBox Listbox)
        {
            Textbox.Text = Listbox.SelectedItems[0].ToString();
            Listbox.Items.Clear();
        }

        //DoubleClick Event um die Startstation in die TextBox einzufügen
        private void lbStartstation_DoubleClick(object sender, EventArgs e)
        {
            StationWaehlen(txtStartstation, lbStartstation);
        }

        //DoubleClick Event um die Zielstation in die TextBox einzufügen
        private void lbZielstation_DoubleClick(object sender, EventArgs e)
        {
            StationWaehlen(txtZielstation, lbZielstation);
        }

        //DoubleClick Event um die beliebige Station in die TextBox einzufügen
        private void lbBeliebigestation_DoubleClick(object sender, EventArgs e)
        {
            txtBeliebigeStation.Tag = lbBeliebigeStation.SelectedItems[0];
            StationWaehlen(txtBeliebigeStation, lbBeliebigeStation);
        }

        //Button um die ausgefüllten Felder wieder zu löschen
        private void btnLoeschen_Click(object sender, EventArgs e)
        {
            txtStartstation.Text = String.Empty;
            txtZielstation.Text = String.Empty;
            lvAusgabe.Items.Clear();
        }
        
        //Button um nach den Verbindungen zu suchen
        private void btnSuchen_Click(object sender, EventArgs e)
        {
            try
            {
                lvAusgabe.Items.Clear();
                Connections Verbindungen = VerbindungSuchen(txtStartstation.Text, txtZielstation.Text, dateTimePicker1.Text);
                VerbindungAnzeigen(Verbindungen);
            }
            catch
            {

            }
        }

        //Methode um Verbindungen zu suchen
        private Connections VerbindungSuchen(string fromStation, string toStation, string time)
        {
            Connections Verbindungen = t.GetConnections(fromStation, toStation, time);
            return Verbindungen;
        }

        //Methode um Verbindung zu suchen
        private void VerbindungAnzeigen(Connections Verbindungen)
        {
            //Datum, Zeit, Von, Nach, Gleis, Verspätung
            foreach(Connection c in Verbindungen.ConnectionList)
            {
                ListViewItem item = new ListViewItem();
                DateTime Abfahrtszeit = Convert.ToDateTime(c.From.Departure);
                item.Text = Abfahrtszeit.Date.ToString("dd.MM.yyyy");
                item.SubItems.Add(Abfahrtszeit.TimeOfDay.ToString());
                item.SubItems.Add(c.From.Station.Name);
                item.SubItems.Add(c.To.Station.Name);
                item.SubItems.Add(c.From.Platform);
                item.SubItems.Add(c.From.Delay.ToString() + " min");

                lvAusgabe.Items.Add(item);
            }
        }

        //Button für das Abfragen und Anzeigen der Abfahrtstaffel
        private void btnAbfahrtstaffel_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> Abfahrtstaffel = new List<string>();

                StationListViewItem item = txtBeliebigeStation.Tag as StationListViewItem;

                StationBoardRoot sb = t.GetStationBoard(item.Station.Name, item.Station.Id);

                foreach (StationBoard sTemp in sb.Entries)
                {
                    Abfahrtstaffel.Add(sTemp.Category + "  " + sTemp.Number + "  " + sTemp.To + "  " + sTemp.Stop.Departure.ToShortTimeString());
                }
                lbAbfahrtstaffel.DataSource = Abfahrtstaffel;
            }
            catch
            {

            }
        }

        //Tastenfunktionen
        private void KeyBewegen(KeyEventArgs e, ListBox Listbox, TextBox Textbox)
        {
            try
            {
                if(e.KeyCode == Keys.Down)
                {
                    Listbox.SelectedIndex++;
                }

                else if (e.KeyCode == Keys.Up)
                {
                    Listbox.SelectedIndex--;
                }

                else if (e.KeyCode == Keys.Enter)
                {
                    StationWaehlen(Textbox, Listbox);
                }
            }
            catch
            {

            }
        }

        private void BewegenStart(object sender, KeyEventArgs e)
        {
            KeyBewegen(e, lbStartstation, txtStartstation);
        }

        private void BewegenZiel(object sender, KeyEventArgs e)
        {
            KeyBewegen(e, lbZielstation, txtZielstation);
        }

        private void BewegenBeliebigeStation(object sender, KeyEventArgs e)
        {
            KeyBewegen(e, lbBeliebigeStation, txtBeliebigeStation);
        }

        //Button für die Reverse-Funktion
        private void btnWechseln_Click(object sender, EventArgs e)
        {
            string Wechseln = txtStartstation.Text;
            txtStartstation.Text = txtZielstation.Text;
            txtZielstation.Text = Wechseln;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
