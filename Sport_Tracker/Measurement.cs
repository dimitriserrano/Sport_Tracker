using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sport_Tracker
{
    class Measurement
    {
        public float Weight { get; set; }

        public Measurement(float newWeight)
        {
            Weight = newWeight;
        }

        /*public override string ToString()
        {
            return $"{Weight}kg le {DateWeight.ToString("d")}";
        }*/

    }
}
