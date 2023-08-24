using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.ComponentModel.DataAnnotations;

namespace DronerOpgave
{
    internal class Program
    {

        static void Main(string[] args)
        {
            File.Delete("doneText.csv");
            string theText = File.ReadAllText("flyvning1.csv");

            String[] spearator = { ";", "\n" };
            Int32 count = int.MaxValue;

            // using the method
            String[] strlist = theText.Split(spearator, count,
                   StringSplitOptions.RemoveEmptyEntries);


        for (int i = 0; i < strlist.Length; i++)
        {
         Console.WriteLine(strlist[i]);
         File.AppendAllText("doneText.csv", strlist[i]+"\n");
        }

                                
            for(int i = 17; i < strlist.Length; i++)
            {
            string longData[] = new string[];
            }     

        }
    }
}