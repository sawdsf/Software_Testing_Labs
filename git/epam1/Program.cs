using System;

namespace epam1
{
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
