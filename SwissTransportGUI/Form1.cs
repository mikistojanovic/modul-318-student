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

            //Die aktuelle Uhrzeit wird als Standard festgelegt
            this.dateTimePicker1.Value = DateTime.Now;
        }

        Transport t = new Transport();

        //Methode um eine Station in der "Startstation" zu suchen
        private void StationSuchen(string stationsName, ListBox listBoxName)
        {
            listBoxName.Items.Clear();

            Stations meineStationen = t.GetStations(stationsName);

            foreach(Station station in meineStationen.StationList)
            {
                try
                {
                    StationListViewItem item = new StationListViewItem(station);
                    listBoxName.Items.Add(item);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
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

        //Methode um eine Station aus der Listbox zu auszuwählen
        private void StationWaehlen(TextBox textBox, ListBox listBox)
        {
            textBox.Text = listBox.SelectedItems[0].ToString();
            listBox.Items.Clear();
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
            dateTimePicker1.Text = String.Empty;
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Methode um Verbindungen zu suchen
        private Connections VerbindungSuchen(string vonStation, string nachStation, string time)
        {
            Connections Verbindungen = t.GetConnections(vonStation, nachStation, time);
            return Verbindungen;
        }

        //Methode um Verbindung zu suchen
        private void VerbindungAnzeigen(Connections verbindungen)
        {
            //Datum, Zeit, Von, Nach, Gleis, Verspätung
            foreach(Connection c in verbindungen.ConnectionList)
            {
                ListViewItem item = new ListViewItem();
                DateTime abfahrtszeit = Convert.ToDateTime(c.From.Departure);
                item.Text = abfahrtszeit.Date.ToString("dd.MM.yyyy");
                item.SubItems.Add(abfahrtszeit.TimeOfDay.ToString());
                item.SubItems.Add(c.From.Station.Name);
                item.SubItems.Add(c.To.Station.Name);
                item.SubItems.Add(c.From.Platform);

                lvAusgabe.Items.Add(item);
            }
        }

        //Button für das Abfragen und Anzeigen der Abfahrtstaffel
        private void btnAbfahrtstaffel_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> abfahrtstaffel = new List<string>();

                StationListViewItem item = txtBeliebigeStation.Tag as StationListViewItem;

                StationBoardRoot sb = t.GetStationBoard(item.Station.Name, item.Station.Id);

                foreach (StationBoard sTemp in sb.Entries)
                {
                    abfahrtstaffel.Add(sTemp.Category + "  " + sTemp.Number + "  " + sTemp.To + "  " + sTemp.Stop.Departure.ToShortTimeString());
                }
                lbAbfahrtstaffel.DataSource = abfahrtstaffel;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Tastenfunktionen
        private void KeyBewegen(KeyEventArgs e, ListBox listBox, TextBox textBox)
        {
            try
            {
                if(e.KeyCode == Keys.Down)
                {
                    listBox.SelectedIndex++;
                }

                else if (e.KeyCode == Keys.Up)
                {
                    listBox.SelectedIndex--;
                }

                else if (e.KeyCode == Keys.Enter)
                {
                    StationWaehlen(textBox, listBox);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
            string wechseln = txtStartstation.Text;
            txtStartstation.Text = txtZielstation.Text;
            txtZielstation.Text = wechseln;
        }

        //Tabwechsel
        private void TabWechseln(TabPage TabPageName)
        {
            tabControl1.SelectTab(TabPageName);
        }

        //Button um die Tabs zu wechseln
        private void btnStandort_Click(object sender, EventArgs e)
        {
            try
            {
                TabWechseln(tabPage2);
                GoogleMaps(txtBeliebigeStation.Text);
            }
            catch
            {
                MessageBox.Show("Geben Sie bitte eine gültige Station ein.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //Google Maps
        private void GoogleMaps(string stationName)
        {
            Station stations = t.GetStations(stationName).StationList.First();

            string xcoordinate = stations.Coordinate.XCoordinate.ToString();
            string ycoordinate = stations.Coordinate.YCoordinate.ToString();
            webBrowser1.Url = new System.Uri("https://www.google.com/maps?q=" + xcoordinate.Replace(",",".") + "," + ycoordinate.Replace(",", "."), System.UriKind.Absolute);
        }
    }
}
