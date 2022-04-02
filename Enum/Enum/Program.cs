using System;
using System;

namespace Enum
{
    public class Program
    {
        static void Main(string[] args)
        {
            //int x = (int)Season.Winter;
            //int y = (int)Season.Summer;

            //Console.WriteLine("Winter: {0}",x);
            //Console.WriteLine("Summer: {0}",y);

            int x = (int)Days.Sun;
            int y = (int)Days.Wed;
            int z = (int)Days.Thu;

            Console.WriteLine("Sunday: {0}", x);
            Console.WriteLine("Wendesday: {0}", y);
            Console.WriteLine("Thursday: {0}", z);

            Console.WriteLine("**********");

            foreach (string d in Enum.GetNames(typeof(Days)))
            {
                Console.WriteLine(d);
            }


        }

        public enum Season
        {
            Winter = 10,
            Spring,
            Summer,
            Fall
        }
        public enum Days { Sun, Mon, Tue, Wed, Thu, Fri, Sat };
    }
    
}
