using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeehiveManagementSystemExtendWithBeeClass
{
    public class Bee
    {
        public const double HoneyUnitsPerMg = 0.25;

        public double WeightMg { get; private set; }

        public Bee(double weightMg)
        {
            WeightMg = weightMg;
        }

        virtual public double HoneyConsumpionRate()
        {
            return HoneyUnitsPerMg * WeightMg;
        }
    }
}
