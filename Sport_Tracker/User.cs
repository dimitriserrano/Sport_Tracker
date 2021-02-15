using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sport_Tracker
{
    class User
    {
        public List<Measurement> Measurements { get; set; } = new List<Measurement>();

        public void AddWeight(float weight, DateTime date)
        {
            var newWeight = new Measurement(weight, date);
            Measurements.Add(newWeight); 
        }

        public User()
        {

        }
    }
}
