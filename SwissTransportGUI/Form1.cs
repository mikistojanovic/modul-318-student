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
                listBoxName.Items.Add(station.Name);
            }

        }

        //Methode um Verbindung auszugeben
        private void Ausgabe(ListView lvAusgabe)
        {
           
        }

        private void txtStartstation_TextChanged(object sender, EventArgs e)
        {
            StationSuchen(txtStartstation.Text, lbStartstation);
        }

        private void txtZielstation_TextChanged(object sender, EventArgs e)
        {
            StationSuchen(txtZielstation.Text, lbZielstation);
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
            Connections verbindungen = VerbindungSuchen(txtStartstation.Text, txtZielstation.Text);
            VerbindungAnzeigen(verbindungen);
        }

        //Methode um Verbindungen zu suchen
        private Connections VerbindungSuchen(string fromStation, string toStation)
        {
            Connections verbindungen = t.GetConnections(fromStation, toStation);

            return verbindungen;
        }

        //Methode um Verbindung zu suchen
        private void VerbindungAnzeigen(Connections verbindungen)
        {
            //Datum, Von, Nach, Gleis, Dauer

            foreach(Connection c in verbindungen.ConnectionList)
            {
                ListViewItem item = new ListViewItem();
                DateTime Abfahrtszeit = Convert.ToDateTime(c.From.Departure);
                item.Text = Abfahrtszeit.Date.ToString("dd.MM.yyyy");
                item.SubItems.Add(Abfahrtszeit.TimeOfDay.ToString());
                item.SubItems.Add(c.From.Station.Name);
                item.SubItems.Add(c.To.Station.Name);
                item.SubItems.Add(c.From.Platform);

                lvAusgabe.Items.Add(item);
            }
        }
    }
}
