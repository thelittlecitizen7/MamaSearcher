using System;

namespace MamaSearcher
{
    class Program
    {
        static void Main(string[] args)
        {
            MamaSearcher mamaSearcher = new MamaSearcher();
            mamaSearcher.Subscribe("l",PrintArgs);
            mamaSearcher.Subscribe("r", PrintArgs);

            mamaSearcher.PerformSearch("lior");
        }

        public static void PrintArgs(int index , string pattern) 
        {
            Console.WriteLine($"index : {index} , pattern {pattern} ");
        }

        
    }
}
