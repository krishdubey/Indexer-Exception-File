using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IndexerProject
{
    class FileInfoReader
    {
        static void Main(string[] args)
        {
            try
            {
                string s = "g:\\abc.txt";
                FileInfo file = new FileInfo(s);
                StreamReader sr = file.OpenText();
                string data = " ";
                while((data = sr.ReadLine())!= null)
                {
                    Console.WriteLine(data);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
            Console.ReadLine();
        }
    }
}
