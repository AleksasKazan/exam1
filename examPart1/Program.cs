using System;

namespace examPart1
{
    class Program
    {
        static void Main(string[] args)
        {
            int bag1 = Convert.ToInt32(Console.ReadLine());
            int bag2 = Convert.ToInt32(Console.ReadLine());
            int bag3 = Convert.ToInt32(Console.ReadLine());
            int bag4 = Convert.ToInt32(Console.ReadLine());
            int bag5 = Convert.ToInt32(Console.ReadLine());
            CheckHeaviest(bag1, bag2, bag3, bag4, bag5);
        }

        static void CheckHeaviest(int bag1, int bag2, int bag3, int bag4, int bag5)
        {
            //at first weight bag1 and bag2 together
            //at second weight bag3 bag4 and bag5 together
            if (((bag1 + bag2) / 2) > (bag3 + bag4 + bag5) / 3)
            {
                //next weight bag1
                if (bag1 > bag2)
                {
                    Console.WriteLine("Heaviest is bag bag1");
                }
                else
                {
                    Console.WriteLine("Heaviest is bag bag2");
                }
            }

            //else weight bag3 and bag4 together
            else
            {
                if ((bag1 + bag2) < (bag3 + bag4))
                {
                    //next weight bag3
                    if (bag3 > bag4)
                    {
                        Console.WriteLine("Heaviest is bag bag3");
                    }
                    else
                    {
                        Console.WriteLine("Heaviest is bag bag4");
                    }
                }
                else
                {
                    Console.WriteLine("Heaviest is bag bag5");
                }
            }
        }
    }
}
