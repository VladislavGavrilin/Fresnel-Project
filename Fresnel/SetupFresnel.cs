using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fresnel
{
    class SetupFresnel
    {
        public double StepCalculation(double freq, double height, double width, double dist, double rpArea)
        {
            double step = freq + height + width + dist + rpArea;
            return step;
        }
    }
}
