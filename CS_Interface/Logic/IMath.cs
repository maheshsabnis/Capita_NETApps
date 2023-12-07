using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Interface.Logic
{
    internal interface IMath
    {
        int Add(int x,int y);
        double Power(double x, double y);
    }


    internal interface INewMath
    {
        int Add(int x, int y);
        double Power(double x, double y);
    }
}
