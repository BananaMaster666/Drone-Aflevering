﻿using System;
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
            File.Delete("Flyvning2.csv");
            string theText = File.ReadAllText("flyvning1.csv");

            String[] spearator = { ";", "\n", "\r"};
            Int32 count = int.MaxValue;

            // Teksten bliver splittet
            String[] strlist = theText.Split(spearator, count,
                   StringSplitOptions.RemoveEmptyEntries);

        // Longittude data læsning
    List<string> longtitudeData = new List<string>();                 
            for(int i = 16; i < strlist.Length; i++)
            {
           // Console.WriteLine("long data " + i + ":" + brokenLongData);
       strlist[i] = strlist[i].Replace(".", "");
       strlist[i] = strlist[i].Insert(1, ".");
       longtitudeData.Add(strlist[i]);
       
            i = (i+12);
            }   

        // Latitude data læsning 
    List<string> latitudeData = new List<string>();                   
            for(int i = 17; i < strlist.Length; i++)
            {
           // Console.WriteLine("lat data " + i + ":" + brokenLatData);

         strlist[i] = strlist[i].Replace(".", "");
         strlist[i] = strlist[i].Insert(2, ".");
         latitudeData.Add(strlist[i]);
            i = (i+12);
            }    

        for(int i=0; i<12; i++)
        {
            File.AppendAllText("Flyvning2.csv", strlist[i]+";");
        }
        File.AppendAllText("Flyvning2.csv", "GPSKoord\n");

    List<string> samledeData = new List<string>();
        for(int i = 0; i < latitudeData.Count; i++)
        {
            samledeData.Add("("+longtitudeData[i]+";"+latitudeData[i]+")");
        }

            int j = 1;
            int k = 0;
            for(int i = 14; i<strlist.Length; i++)
            {
            if(j%13==0)
            {
            File.AppendAllText("Flyvning2.csv", strlist[i] + ";" + samledeData[k] + "\n");
            k++;
            }
            else
            {
            File.AppendAllText("Flyvning2.csv", strlist[i]+";");
            }
            j++;
            }
        }
    }
}