using SwissTransport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwissTransportGUI
{
    class StationListViewItem
    {
        public StationListViewItem(Station station)
        {
            Station = station;
        }

        public Station Station { get; set; }


        public override string ToString()
        {
            return Station.Name;
        }
    }
}
