using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Interface.Logic
{
    /// <summary>
    /// Interface Implementation
    /// Currently the Mathematics class implements IMath interface
    /// Implicitly
    /// </summary>
    internal class Mathematics : IMath 
    {
        public int Add(int x,int y)
        { 
            return x + y;
        }

        public double Power(double x, double y)
        {
            return Math.Pow(x,y);
        }
    }
}
