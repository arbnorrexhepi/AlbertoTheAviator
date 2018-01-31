using System;
using System.Collections.Generic;
using System.Linq;

namespace AlbertoTheAviator
{
    public class Flight
    {
        public int Delta;
        public int Duration;
        public int Refuel;
    }
    public class AlbertoTheAviator
    {
        public int MaximumFlights(int F, int[] duration, int[] refuel)
        {
            

            if (duration.Length == refuel.Length)
            {
                int missionsNumber = 0;
                Dictionary<int, Flight> availableFlights = new Dictionary<int, Flight>();

                for (int k = 0; k < duration.Length; k++)
                {
                    if (duration[k] <= F)
                    {
                        Flight flight = new Flight();
                        flight.Duration = duration[k];
                        flight.Refuel = refuel[k];
                        flight.Delta = F - duration[k] + refuel[k];

                        availableFlights.Add(k, flight);

                    }
                }

                var sortedavailableFlights = availableFlights.OrderByDescending(x => x.Value.Delta);



                foreach (KeyValuePair<int, Flight> item in sortedavailableFlights)
                {
                    F = F - item.Value.Duration + item.Value.Refuel;

                    if (F >= 0)
                    {
                        missionsNumber++;
                    }
                    else
                    {
                        break;
                    }
                }
                return missionsNumber;
            }
            else
            {
              
                return -1;
            }
            
        }



        static void Main(string[] args)
        {
            AlbertoTheAviator test = new AlbertoTheAviator();

            Console.WriteLine("   Examples\n");
            Console.WriteLine("--------------------------------");

            int[] durations1 = { 10 };
            int[] refuel1 = { 0 };

            var m1 = test.MaximumFlights(10, durations1, refuel1);
            if (m1 >= 0)
            {

                Console.WriteLine("   0)");
                Console.WriteLine("   10");
                Console.WriteLine("  {10}");
                Console.WriteLine("  {0}");
                Console.WriteLine("  Return: {0}", m1);
                Console.WriteLine("  There is only one mission. Alberto has enough fuel to take it, so the optimal solution is to take it.");

            } else
            {
                Console.WriteLine("  Duration and Refuel must have same length");
            }

            Console.WriteLine("--------------------------------");

            int[] durations2 = { 8, 4 };
            int[] refuel2 = { 0, 2 };

            var m2 = test.MaximumFlights(10, durations2, refuel2);
            if (m2 >= 0)
            {
                Console.WriteLine("   1)");
                Console.WriteLine("   10");
                Console.WriteLine("  {8,4}");
                Console.WriteLine("  {0,2}");
                Console.WriteLine("  Return: {0}", m2);
            }
            else
            {
                Console.WriteLine("  Duration and Refuel must have same length");
            }

            Console.WriteLine("--------------------------------");

            int[] durations3 = { 4, 8, 2, 1 };
            int[] refuel3 = { 2, 0, 0, 0 };

            var m3 = test.MaximumFlights(10, durations3, refuel3);
            if (m3 >= 0)
            {
                Console.WriteLine("   2)");
                Console.WriteLine("   12");
                Console.WriteLine("  {4,8,2,1}");
                Console.WriteLine("  {2,0,0,0}");
                Console.WriteLine("  Return: {0}", m3);
            }
            else
            {
                Console.WriteLine("  Duration and Refuel must have same length");
            }

            Console.WriteLine("--------------------------------");

            int[] durations4 = { 4, 6 };
            int[] refuel4 = { 0, 1 };

            var m4 = test.MaximumFlights(9, durations4, refuel4);
            if (m4 >= 0)
            {
                Console.WriteLine("   3)");
                Console.WriteLine("   9");
                Console.WriteLine("  {4,6}");
                Console.WriteLine("  {0,1}");
                Console.WriteLine("  Return: {0}", m4);
            }
            else
            {
                Console.WriteLine("  Duration and Refuel must have same length");
            }


            Console.WriteLine("--------------------------------");

            int[] durations5 = { 101 };
            int[] refuel5 = { 100 };

            var m5 = test.MaximumFlights(100, durations5, refuel5);
            if (m5 >= 0)
            {
                Console.WriteLine("   4)");
                Console.WriteLine("   100");
                Console.WriteLine("  {101}");
                Console.WriteLine("  {100}");
                Console.WriteLine("  Return: {0}", m5);
                Console.WriteLine("  There is only one mission. Alberto does not have enough fuel to take it. The answer is {0}.", m5);
            }
            else
            {
                Console.WriteLine("  Duration and Refuel must have same length");
            }

            Console.WriteLine("--------------------------------");

            int[] durations6 = { 2407, 2979, 1269, 2401, 3227, 2230, 3991, 2133, 3338, 356, 2535, 3859, 3267, 365 };
            int[] refuel6 = { 2406, 793, 905, 2400, 1789, 2229, 1378, 2132, 1815, 355, 72, 3858, 3266, 364 };

            var m6 = test.MaximumFlights(1947, durations6, refuel6);
            if (m6 >= 0)
            {
                Console.WriteLine("   5)");
                Console.WriteLine("  1947");
                Console.WriteLine(" {2407, 2979, 1269, 2401, 3227, 2230, 3991, 2133, 3338, 356, 2535, 3859, 3267, 365}");
                Console.WriteLine(" {2406, 793, 905, 2400, 1789, 2229, 1378, 2132, 1815, 355, 72, 3858, 3266, 364}");
                Console.WriteLine(" Return: {0}", m6);
            }
            else
            {
                Console.WriteLine("  Duration and Refuel must have same length");
            }

            Console.ReadLine();

        }
    }
}

