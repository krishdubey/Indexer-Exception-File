using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IndexerProject
{
    class Directory1
    {
        static void Main(string[] args)
        {
            DirectoryInfo directory = new DirectoryInfo(@"g:\\C#Data");
            try
            {
                if(directory.Exists)
                {
                    Console.WriteLine("Directory already exist.");
                    return;
                }
                directory.Create();
                Console.WriteLine("The directory is created successfully");
            }
            catch(Exception e)
            {
                Console.WriteLine("Directory not created:{0}", e.ToString());
            }
            Console.ReadLine();
        }
    }
}
