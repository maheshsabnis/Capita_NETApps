using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_GenericStack.Utilities
{
    /// <summary>
    /// The Generic class
    /// </summary>
    /// <typeparam name="T"></typeparam>
    internal class GenericStack<T>
    {
        // Generic Member
        T[] arr = new T[5];
        int top = 0;

        // a Geberic method
        public void Push(T item)
        {
            arr[top++] = item;
        }
        public T Pop() 
        {
            return arr[--top];
        }

        public T[] ShowEntrties()
        {
            return arr;
        }
    }
}
