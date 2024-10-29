using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stubs
{
    internal class TestDataObject
    {
        public List<(string Name, long Size)> GetFiles()
        {
            List<(string Name, long Size)> list = new List<(string, long)>
            {
                ("main.log", 2048),
                ("file1.txt", 1024),
                ("file2.log", 512),
                ("file3.exe", 4096)
            };

            return list;
        }
    }
}
