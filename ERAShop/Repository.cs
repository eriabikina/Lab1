using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERAShop {
    public class Repository {

        public string BuildPath (string folderName, string fileName) {
            string path = Environment.CurrentDirectory + "/" + folderName;
            if (!Directory.Exists (path)) {
                Directory.CreateDirectory (path);
            }
            path += "/" + $"{fileName}.txt";

            return path;
        }

    }
}
