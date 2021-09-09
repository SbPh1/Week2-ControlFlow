using System;

namespace ControlFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja vanust
            //kui kasutaja on vanem kui 18, siis konsoolis kuvatakse "Oled piisavalt vana"
            //kui kasutaja on noorem kui 18, siis konsoolis kuvatakse "Pole piisavalt vana"
            //kui kasutaja on 18, siis konsoolis kuvatakse "oledki 18"

            Console.WriteLine("Insert Age");
            int Age = Convert.ToInt32(Console.ReadLine());

            if (Age > 18)
            {
                Console.WriteLine("Old Enough");
            }
            else if (Age < 18)
            { 
                Console.WriteLine("Too Young");
            }
            else
            {
                Console.WriteLine("Perfecto");
            }
            Console.WriteLine("Have a nice day!");
            Console.Read();
        }
    }
}
