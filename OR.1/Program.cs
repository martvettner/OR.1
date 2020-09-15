using System;

namespace OR._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What month were you born");
            string month = Console.ReadLine().ToLower();

            // || - pipes alt 

            if (month == "december" || month == "january" || month == "february")
            {
                Console.WriteLine("you were born in winter");
            }
            else if (month == "march" || month == "april" || month == "may")
            { 
                Console.WriteLine("you were born in spring");
            }
            else if (month == "june" || month == "july" || month == "august") 
            {
                Console.WriteLine("you were born in summer");
            }
            else if (month == "september" || month == "october" || month == "november")
            { 
                Console.WriteLine("you were born in spring");
            }
            else
            {
                Console.WriteLine($"{month} is not a month");
            }



        }
    }
}
