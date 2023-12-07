
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Interface.Logic
{
    /// <summary>
    /// With An Explicit Implementation of Interface
    /// </summary>
    internal class MathematicsExplicit : IMath, INewMath
    {
        int IMath.Add(int x, int y) 
        {
            return x + y;
        }

        int INewMath.Add(int x, int y)
        {
            return (x * x) + 2 * x * y + (y * y);
        }

        double IMath.Power(double x, double y) 
        {
            return Math.Pow(x, y); 
        }

        double INewMath.Power(double x, double y)
        {
            return Math.Pow(x,y) + Math.Pow(y, x);
        }
    }
}
