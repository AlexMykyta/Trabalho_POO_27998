using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    using System.IO;

    public class Registry
    {
        public void SaveToFile(string fileName, string content)
        {
            File.WriteAllText(fileName, content);
        }

        public string LoadFromFile(string fileName)
        {
            return File.Exists(fileName) ? File.ReadAllText(fileName) : string.Empty;
        }
    }

}
