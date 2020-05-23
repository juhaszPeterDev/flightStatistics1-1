using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vers
{
    class Program
    {
        static void Main(string[] args)
        {
            string caesarCode = File.ReadAllText("caesar.txt");
            string xywCount = File.ReadAllText("count-x-y-w.txt");
            string afterz = File.ReadAllText("after-z.txt");

            Caesar codedText = new Caesar(caesarCode, xywCount, afterz);

            //codedText.Kiir();

            if (File.Exists("vers-dekodolva.txt"))
            {
                File.Delete("vers-dekodolva.txt");
            }
            File.WriteAllText("vers-dekodolva.txt", codedText.Dekode());

            //Console.ReadKey();

        }
    }
}
