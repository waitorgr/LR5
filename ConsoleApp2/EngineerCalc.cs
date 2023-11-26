using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB6
{
    public class EngineerCalc : OrdinaryCalc
    {
        public EngineerCalc() : base()
        {

        }

        public double Exp()
        {
            double limitedNum1 = Math.Max(Math.Min(base.GetNum1(), 5.0), -5.0);

            return Math.Exp(limitedNum1);
        }

    }
}
