using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F4StoresSim
{
    enum SMSModes
    {
        OFF, STBY, INV, MDDE, SJ, EJ, MSL, DGFT, AAM, AG, GUN, BIT
    }

    static class MFDSet
    {
        // MFDSet is a ViewModel object that simulates the internal state of the MFD Set. 
        // MFDSet manipulates and reads the properties of Model objects, and has properties which are databound to by the View, either MFDBezel or MFDClean.

        static int curMode;

        static List<MFDPage> Pages;

        // public properties to be something the View (MFDBezel) can databind to?
    }
}
