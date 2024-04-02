using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    internal class Sedan : Vehicle
    {
        public Sedan(double speed) : base(speed)
        {
            Wheels = 4;
        }

        public override string Describe()
        {
            return $"This Sedan is moving on {Wheels} wheels at {Speed} km/h, with license plate {LicensePlate}.";
        }
    }
}
