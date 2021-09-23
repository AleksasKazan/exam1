using System;

namespace examPart1
{
    class Program
    {
        static void Main(string[] args)
        {
            double bag1 = Convert.ToDouble(Console.ReadLine());
            double bag2 = Convert.ToDouble(Console.ReadLine());
            double bag3 = Convert.ToDouble(Console.ReadLine());
            double bag4 = Convert.ToDouble(Console.ReadLine());
            double bag5 = Convert.ToDouble(Console.ReadLine());
            CheckHeaviest(bag1, bag2, bag3, bag4, bag5);
        }

        static void CheckHeaviest(double bag1, double bag2, double bag3, double bag4, double bag5)
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
