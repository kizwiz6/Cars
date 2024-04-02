using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    internal interface IAutomobile
    {
        string LicensePlater { get; }
        double speed { get; }
        int Wheel {  get; }
        void Honk();
    }
}
