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

        //Methode um eine Station in der "Startstation" zu suchen
        private void StationSuchen(string Stationsname, ListBox listBoxName)
        {
            listBoxName.Items.Clear();

            Transport t = new Transport();

            Stations myStations = t.GetStations(Stationsname);

            foreach(Station station in myStations.StationList)
            {
                listBoxName.Items.Add(station.Name);
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
    }
}
