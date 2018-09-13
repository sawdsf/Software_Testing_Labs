using System;

namespace epam1
{
    static class Studens
    {

        static string[,] group = new string[10, 6] 
        {
            {"1","Павел","4","5","5","6" },
            {"2","Артём","3","4","6","7" },
            {"3","Юлия","9","1","5","9" },
            {"4","Марина","5","8","7","8" },
            {"5","Анастасия","6","3","4","2" },
            {"6","Алексей","8","9","5","1" },
            {"7","Дзяніс","5","6","4","5" },
            {"8","Влад","3","2","4","5" },
            {"9","Алла","5","8","9","7" },
            {"10","Юрий","9","8","3","4" },
        };
        public static void vivod_sr_st(string name)
        {
            for (int i = 0; i < Studens.group.Length / 6; i++)
            {
                if (name == Studens.group[i, 1])
                {
                    double sr = 0;
                    for (int j = 2; j < 6; j++)
                        sr = sr + Convert.ToInt32(Studens.group[i, j]);
                    sr = sr / 4;
                    Console.WriteLine(sr);
                }
            }
        }
        public static void vivod_sr_gr()
        {
            double sr=0;
            for (int i = 0; i < Studens.group.Length / 6; i++)
                for (int j = 2; j < 6; j++)
                    sr=sr+ Convert.ToInt32(Studens.group[i, j]);
            sr = sr / (Studens.group.Length * 4 / 6);
            Console.WriteLine(sr);

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            while (1 > 0)
            {
                Console.WriteLine("1-средний по студенту:2-средний по группе");
                int number = Convert.ToInt32(Console.ReadLine());
                if (number == 0) break;
                switch (number)
                {
                    case 1:
                        Console.WriteLine("Имя студента");
                        Studens.vivod_sr_st(Console.ReadLine());
                        break;
                    case 2:
                        Studens.vivod_sr_gr();
                        break;
                }
            }


        }
    }
}
