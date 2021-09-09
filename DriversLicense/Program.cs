using System;

namespace DriversLicense
{
    class Program
    {
        static void Main(string[] args)
        {
            //pragramm küsib kasutaja sünniaastat
            //programm kontrollib kasutaja vanust
            //programm teavitab kasutajat kas ta on piisavalt vana
            //et juhiluba saada on tingimuseks olla 18 aastat vana

            Console.WriteLine("Sisestage sünniaasta");
            int YearOfBirth = Convert.ToInt32(Console.ReadLine());
            int Age = 2021 - YearOfBirth;

            if (Age >= 18)
            {
                Console.WriteLine("Congrats, old enough!");
            }
            else
            {
                Console.WriteLine("Too young!");
            }
            //if (Age < 18)
            //{
            //    Console.WriteLine("Too young!");
            //}
            //else
            //{
            //    Console.WriteLine("Congrats, old enough!");
            //}
            Console.Read();
        }
    }
}
