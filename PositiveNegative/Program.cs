using System;

namespace PositiveNegative
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm palub kasutajal sisestada numbrid -10 kuni 10
            //programm kontrollib numbrit
            //kui nr on positiivne, konsool kuvab "positive"
            //kui nr on neg, konsool kuvab "negative"
            //kui nr on 0, konsool kuvab "null"

            Console.WriteLine("Insert a number between -10 and 10");

            int UserNumber = Convert.ToInt32(Console.ReadLine());

            if (UserNumber > 0)
            {
                Console.WriteLine("Positive");
            }
            else if (UserNumber < 0)
            {
                Console.WriteLine("Negative");
            }
            else
            {
                Console.WriteLine("Zero");
            }
            Console.Read();
        }
    }
}
