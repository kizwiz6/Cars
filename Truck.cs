using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    internal class Truck : Vehicle
    {
        public double Weight
        { get; }


        public Truck(double speed, double weight) : base(speed)
        {
            Weight = weight;

            if (weight < 400)
            {
                Wheels = 8;
            }
            else
            {
                Wheels = 12;
            }
        }

        public override string Describe()
        {
            return $"This Truck is moving on {Wheels} wheels at {Speed} km/h, with license plate {LicensePlate}.";
        }
    }
}
