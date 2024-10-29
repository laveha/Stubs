using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stubs
{
    internal class FileDataObject
    {
        public List<FileInfo> GetFiles()
        {
            string path = "D:\\Проекты\\stub-master\\Stub";

            DirectoryInfo directory = new DirectoryInfo(path);
            return directory.GetFiles().ToList();
        }
    }
}
