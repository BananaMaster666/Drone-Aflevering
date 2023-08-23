using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DronerOpgave
{
    internal class Program
    {

        static void Main(string[] args)
        {
            File.Delete("text.csv");
            string theText = File.ReadAllText("flyvning1.csv");
            Console.WriteLine(theText);


            String[] spearator = { ";" };
            Int32 count = int.MaxValue;

            // using the method
            String[] strlist = theText.Split(spearator, count,
                   StringSplitOptions.RemoveEmptyEntries);

            foreach (String s in strlist)
            {
                Console.WriteLine(s);
                string[] lines = new string[s.Length];
                for (int i = 0; i < lines.Length; i++)
                {
                    lines[i] = s;
                }

            }

        }
    }
}