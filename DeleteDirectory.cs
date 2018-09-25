using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IndexerProject
{
    class DeleteDirectory
    {
        static void Main(string[] args)
        {
            if (Directory.Exists(@"G:\t"))
            {
                try
                {
                    Directory.Delete(@"G:\t", true);
                }

                catch (IOException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            Console.WriteLine("DELETE");
            Console.ReadLine();
        }
    }
}
