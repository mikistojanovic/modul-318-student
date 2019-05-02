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
                StationListViewItem item = new StationListViewItem(station);
                listBoxName.Items.Add(item);
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

        //DoubleClick Event um die Startstation in die TextBox einzufügen
        private void lbStartstation_DoubleClick(object sender, EventArgs e)
        {
            txtStartstation.Text = lbStartstation.SelectedItems[0].ToString();
            lbStartstation.Items.Clear();
        }

        //DoubleClick Event um die Zielstation in die TextBox einzufügen
        private void lbZielstation_DoubleClick(object sender, EventArgs e)
        {
            txtZielstation.Text = lbZielstation.SelectedItems[0].ToString();
            lbZielstation.Items.Clear();
        }

        //DoubleClick Event um die beliebige Station in die TextBox einzufügen
        private void lbBeliebigestation_DoubleClick(object sender, EventArgs e)
        {
            txtBeliebigeStation.Tag = lbBeliebigeStation.SelectedItems[0];
            txtBeliebigeStation.Text = lbBeliebigeStation.SelectedItems[0].ToString(); 
            lbBeliebigeStation.Items.Clear();
        }

        //Button um die ausgefüllten Felder wieder zu löschen
        private void btnLoeschen_Click(object sender, EventArgs e)
        {
            txtStartstation.Text = String.Empty;
            txtZielstation.Text = String.Empty;
            txtZeit.Text = String.Empty;
            dateTimePicker1.Text = String.Empty;
            lvAusgabe.Items.Clear();
        }
        
        //Button um nach den Verbindungen zu suchen
        private void btnSuchen_Click(object sender, EventArgs e)
        {
            Connections Verbindungen = VerbindungSuchen(txtStartstation.Text, txtZielstation.Text);
            VerbindungAnzeigen(Verbindungen);
        }

        //Methode um Verbindungen zu suchen
        private Connections VerbindungSuchen(string fromStation, string toStation)
        {
            Connections Verbindungen = t.GetConnections(fromStation, toStation);

            return Verbindungen;
        }

        //Methode um Verbindung zu suchen
        private void VerbindungAnzeigen(Connections Verbindungen)
        {
            //Datum, Von, Nach, Gleis, Dauer

            foreach(Connection c in Verbindungen.ConnectionList)
            {
                ListViewItem item = new ListViewItem();
                DateTime Abfahrtszeit = Convert.ToDateTime(c.From.Departure);
                item.Text = Abfahrtszeit.Date.ToString("dd.MM.yyyy");
                item.SubItems.Add(Abfahrtszeit.TimeOfDay.ToString());
                item.SubItems.Add(c.From.Station.Name);
                item.SubItems.Add(c.To.Station.Name);
                item.SubItems.Add(c.From.Platform);
                item.SubItems.Add(c.From.Delay.ToString() + "min");

                lvAusgabe.Items.Add(item);
            }
        }

        private void btnAbfahrtstaffel_Click(object sender, EventArgs e)
        {
            List<string> Abfahrtstaffel = new List<string>();

            StationListViewItem item = txtBeliebigeStation.Tag as StationListViewItem;

            StationBoardRoot sb = t.GetStationBoard(item.Station.Name, item.Station.Id);

            foreach(StationBoard sTemp in sb.Entries)
            {
                Abfahrtstaffel.Add(sTemp.Name + "" + sTemp.Category + "" + sTemp.Number + "" + sTemp.To + "" + sTemp.Operator + "" + sTemp.Stop.Departure.ToShortTimeString());

            }

            lbAbfahrtstaffel.DataSource = Abfahrtstaffel;
        }
    }
}
