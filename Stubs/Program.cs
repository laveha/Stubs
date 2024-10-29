using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stubs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long fileSize = 184;

            FileManager fileManager = new FileManager();
            string fileName = fileManager.FindLogFile(fileSize);

            if (fileName != null)
            {
                Console.WriteLine("Файл с размером {0} байт найден: {1}", fileSize, fileName);
            }
            else
            {
                Console.WriteLine("Файл с размером {0} байт не найден!", fileSize);
            }

            Console.ReadKey();
        }
    }
}
