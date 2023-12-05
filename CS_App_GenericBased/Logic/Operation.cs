using CS_App_GenericBased.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_App_GenericBased.Logic
{
    /// <summary>
    /// A Generic Operation Class
    /// 'where T : class' means any valid .NET Class
    /// where T : Employee means T is either Employee or any Derived Type of Employee
    /// </summary>
    /// <typeparam name="T"></typeparam>
    internal class Operation<T> where T : Employee
    {
        List<T> list;
        public Operation()
        {
            list = new List<T>();
        }
         // The Add Methods
        public void Add(T item) 
        {
            list.Add(item);
        }
        public void Remove(T item) 
        {
            // Remove specific Record from the collection
            list.Remove(item);
        }
        public void Clear() 
        {
            ///Clear the collection
            list.Clear();
        }
        public List<T> GetValues()
        {
            return list;
        }
    }
}
