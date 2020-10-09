using System;
using System.IO;
using System.Text.Json;

namespace decouverteStream
{
    class Program
    {
        static void Main(string[] args)
        {

            FileStream file1 = new FileStream(@"./file1.txt", FileMode.Create);
            //byte[] contenuDuFichier = new byte[] { (byte)'c', (byte)'o' };
            //file1.Write(contenuDuFichier, 0, 2);
            //file1.Flush();

            StreamWriter sw = new StreamWriter(file1);
            sw.Write("contenu du fichier:");
            sw.Flush();
            file1.Close();
        }
    }
}
