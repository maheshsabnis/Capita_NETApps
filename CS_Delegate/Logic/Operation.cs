using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Delegate.Logic
{
    // 1. Declare a Delegate at NAmepsace level
    // Signeture is 2 int input parameters and int output patrameter
    // This will be used to invoke the matching signeture method
    public delegate int OperationHandler (int x, int y);

    internal class Operation
    {
        public int Add(int x,int y)
        {
            return x + y;
        }
    }
}
