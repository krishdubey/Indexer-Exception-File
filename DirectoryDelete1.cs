using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IndexerProject
{
    class DirectoryDelete1
    {
        static void Main(string[] args)
        {
            DirectoryInfo directory = new DirectoryInfo(@"g:\\c#Data");
            try
            {
                directory.Delete();
                Console.WriteLine("The Directory is deleted successfully.");
            }
            catch(Exception e)
            {
                Console.WriteLine("Something went wrong:{0}", e.ToString());
            }
            Console.ReadLine();
        }
    }
}
