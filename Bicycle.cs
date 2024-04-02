﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    internal class Bicycle : Vehicle
    {
        public Bicycle(double speed) : base(speed)
        {
            Wheels = 2;
        }

        public override void SpeedUp()
        {
            Speed += 5;

            if (Speed > 15)
            {
                Speed = 15;
            }
        }

        public override void SlowDown()
        {
            Speed -= 5;

            if (Speed < 0)
            {
                Speed = 0;
            }
        }

        public override string Describe()
        {
            return $"This Bicycle is moving on {Wheels} wheels at {Speed} km/h, with license plate {LicensePlate}.";
        }
    }
}
