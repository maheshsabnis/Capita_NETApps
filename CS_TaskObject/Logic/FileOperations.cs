using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_TaskObject.Logic
{
    internal class FileOperations
    {
        public string ReadJames()
        {
            Thread.Sleep(1000); // block execution for 1 second

            string contents = string.Empty;

            // System.IO.Stream class to perform operations on File System
            // StreamReader to read file Directly w/o explicit use of FileStream class 
            // The 'using' block will dispose the StreamReader object once the execution of the block is comple
            using (StreamReader reader = new StreamReader(@"C:\Capita\Files\James.txt"))
            { 
                // Read the Complete file
                contents = reader.ReadToEnd();
            } // Here the read object will be disposed / destroyed / thrown out of memory


          

            return contents;
        }

        public string ReadEthan()
        {

            Thread.Sleep(5000); // block execution for 5 second
            string contents = string.Empty;

            // System.IO.Stream class to perform operations on File System
            // StreamReader to read file Directly w/o explicit use of FileStream class 
            // The 'using' block will dispose the StreamReader object once the execution of the block is comple
            using (StreamReader reader = new StreamReader(@"C:\Capita\Files\Ethan.txt"))
            {
                // Read the Complete file
                contents = reader.ReadToEnd();
            } // Here the read object will be disposed / destroyed / thrown out of memory


            return contents;
        }
    }
}
