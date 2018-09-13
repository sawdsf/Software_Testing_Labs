using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace epam1
//изменения
    static class Studens
    {
        static string[][] group;
        static void outFile()
        {
            string[] readText = File.ReadAllLines("..\\..\\..\\group.txt");//считываем все строки в массив
            group = new string[readText.Length][];
            int i = 0;
            foreach (var line in readText)//перебираем строки массива
            {
                group[i] = line.Split(',');
                i++;
            }
        }
        public static void allstudents()
        {
            outFile();
            for (int i = 0; i < Studens.group.Length; i++)
            {
                Console.WriteLine(Studens.group[i][1]);
            }
        }
        public static void vivod_sr_st(string name)
        {
            outFile();
            for (int i = 0; i < Studens.group.Length; i++)
            {
                if (name == Studens.group[i][1])
                {
                    double sr = 0;
                    for (int j = 2; j < 6; j++)
                        sr = sr + Convert.ToInt32(Studens.group[i][j]);
                    sr = sr / 4;
                    Console.WriteLine(sr);
                }
            }
        }
        public static void vivod_sr_gr()
        {
            outFile();
            double sr = 0;
            for (int i = 0; i < Studens.group.Length; i++)
                for (int j = 2; j < 6; j++)
                    sr = sr + Convert.ToInt32(Studens.group[i][j]);
            sr = sr / (Studens.group.Length * 4);
            Console.WriteLine(sr);

        }




    }
}
