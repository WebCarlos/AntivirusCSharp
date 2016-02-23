using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AntivirusForm
{
    public class MetodosAuxiliares
    {
        public string GetMD5HashFromFile(string fileName)
        {
            MD5 md5 = MD5.Create();
            StringBuilder sb = new StringBuilder();

            try
            {
                using (FileStream fs = File.Open(fileName, FileMode.Open))
                    foreach (byte b in md5.ComputeHash(fs))
                        sb.Append(b.ToString("x2").ToLower());
                return sb.ToString();
            }
            catch
            {
                return "";
            }

        }
    }
}
