using System;

namespace AlgoGenTest
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Population test = new Population(10);
            Console.Write(test.getPopScoreTxt());
            test.TrierPopu();
            Console.Write("\n \n \n \n" +test.getPopScoreTxt());
            Console.Write("\n \n \n \n" + test.GetBest());
            Console.ReadLine();
            */

            Individu tes = new Individu();
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(tes.RdmInterval(20) + " \n \n");
            }

            Console.ReadLine();
        }
    }
}
