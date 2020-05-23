using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vers
{
    class Caesar
    {
        private string codedText;
        private string xywText;
        private string afterzText;

        public Caesar(string codedText, string xywText, string afterzText)
        {
            this.codedText = codedText;
            this.xywText = xywText;
            this.afterzText = afterzText;
        }

        public int Count_xyw()
        {
            int counterX = 0;
            int counterY = 0;
            int counterW = 0;
            foreach (var item in xywText)
            {
                if (item=='X')
                {
                    counterX++;
                }
                else if (item == 'Y')
                {
                    counterY++;
                }
                else if (item == 'W')
                {
                    counterW++;
                }
            }
            return counterX + counterY - counterW;
        }

        public int AfterZ()
        {
            List<int> numbers = new List<int> ();
            for (int i = 0; i < afterzText.Length; i++)
            {
                if (afterzText[i]=='Z' && Char.IsNumber(afterzText[i+1]))
                {
                    numbers.Add(int.Parse(afterzText[i+1].ToString()));
                }
            }
            return (int)numbers.Average();

        }

        public int Fibonacci50()
        {
            ulong a = 0, b = 1, c = 0;
            for (int i = 2; i < 51; i++)
            {
                c = a + b;
                a = b;
                b = c;
            }
            string fib50 = Convert.ToString(c);
            
            return int.Parse(fib50[fib50.Length - 1].ToString())-int.Parse(fib50[0].ToString());

        }

        public string Dekode()
        {
            string poem = "";
            foreach (var item in codedText)
            {
                poem += CharDekode(item);
            }            
            return poem;
        }

       public char CharDekode(char ch)
        {
            if(!char.IsLetter(ch))
                return ch;

            char offset = char.IsUpper(ch) ? 'A' : 'a';
            return (char)((((ch + 26-Key()) - offset) % 26) + offset);
        }

        public void Kiir()
        {
            Console.WriteLine("Eltolás mértéke: "+(Count_xyw()+AfterZ()+Fibonacci50()));
            Console.WriteLine(Dekode());
        }

        public int Key()
        {
            return (Count_xyw() + AfterZ() + Fibonacci50());
        }

    }
}
