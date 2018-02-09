using System;
using System.Windows;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F4StoresSim
{
    abstract class MFDPage
    {
        // osblabels is a List 0-19 of OSBLabels, one for each OSB. Blank labels for blank slots.
        List<OSBLabel> osblabels;

        public List<OSBLabel> OSBLabels
        {
            get { return osblabels; }
        }


    }

    class OSBLabel
    {
        public bool Boxed { get; set; }
        public string Line1 { get; set; }
        public string Line2 { get; set; }
    }

    class SelStationLabel
    {

    }

    class RLabel
    {

    }

    public enum MFDSymbol
    {
        RangeOrVelocityScale,
        ElevationTics,
        AzimuthMarker,
        HorizonLine,
        AircraftReference,
        AzimuthSteeringBar,
        BreakawayCue,
        Increment,
        Decrement,
        TargetRangeCue,
        Steerpoint,
        Ownship,

    }

    class MFDGraphic
    {
        public Point CoOrds { get; set; }

        public 
    }
}
