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
        // osblabels is a Dictionary of OSBLabels indexed by OSB number, zero indexed: OSB1 is found at OSBLabels[0], OSB20 at OSBLabels[19]

        public Dictionary<int, OSBLabel> OSBLabels { get; set; }
    }

    class OSBLabel
    {
        public bool Boxed { get; set; }
        public string Line1 { get; set; }
        public string Line2 { get; set; }
    }

    class SelStationLabel
    {
        public bool IsLeft { get; set; } // specifies which side the label belongs to

        public List<string> Labels { get; set; } // only needs 3 entries; one for each station on the label -  each entry only a single character

        public int BoxedStation { get; set; } // specifies the station which is boxed; returns null if no station is boxed
    }

    class RLabel
    {
        public Point CoOrds { get; set; }

        public string LabelText;

        // possibly useful to specify size of text - height, etc
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
        OffLetters
    }

    class MFDGraphic
    {
        public Point CoOrds { get; set; }

        public int Symbol;

        public int Orientation; // unused for SMS page but it would be useful for growth
    }
}
