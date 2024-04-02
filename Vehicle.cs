using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    abstract class Vehicle
    {
        public string LicensePlate
        { get; private set; }

        public double Speed
        { get; protected set; }

        public int Wheels
        { get; protected set; }

        protected Vehicle(double speed)
        {
            Speed = speed;
            LicensePlate = "TEST";
        }

        public virtual void SpeedUp()
        {
            Speed += 5;
        }

        public virtual void SlowDown()
        {
            Speed -= 5;
        }

        public void Honk()
        {
            Console.WriteLine("Honk!");
        }

        public abstract string Describe();
    }
}
