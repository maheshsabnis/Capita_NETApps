using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Async_Await.Logic
{
    internal class FileOperations
    {
        public async Task<string> ReadJamesAsync()
        {
            Thread.Sleep(1000); // block execution for 1 second

            string contents = string.Empty;
 
            using (StreamReader reader = new StreamReader(@"C:\Capita\Files\James.txt"))
            { 
                // Read the Complete file
                contents = await reader.ReadToEndAsync();
            } // Here the read object will be disposed / destroyed / thrown out of memory


            return contents;
        }

        public async Task<string> ReadEthanAsync()
        {

            Thread.Sleep(5000); // block execution for 5 second
            string contents = string.Empty;
 
            using (StreamReader reader = new StreamReader(@"C:\Capita\Files\Ethan.txt"))
            {
                // Read the Complete file
                // Put an Awaitable to infor the Runtime that ther is a Thread Execution going on 
                contents = await reader.ReadToEndAsync();
            } // Here the read object will be disposed / destroyed / thrown out of memory


            return contents;
        }
    }
}
