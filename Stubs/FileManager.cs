using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stubs
{
    public class FileManager
    {
        public string FindLogFile(long fileSize)
        {
            FileDataObject fileDataObject = new FileDataObject();
            List<FileInfo> files = fileDataObject.GetFiles();

            foreach (var file in files)
            {
                if (file.Length == fileSize)
                {
                    return file.Name;
                }
            }

            return null;
        }
    }
}
