using System;

namespace WeekSevenAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while(i < 3)
            {

                Console.WriteLine("Sisesta oma kasutajatunnus");
                string userName = Console.ReadLine();
                Console.WriteLine("Sisesta oma parool");
              
                string userPassword = Console.ReadLine();
                Console.WriteLine("Sisesta PIN");
                
               
                if (userName == "admin" && userPassword == "admin1234")
                {
                    Console.WriteLine("Tere tulemast!");
                    break;

                }
                else
                {
                    i = i + 1;
                    Console.WriteLine($"Proovi uuesti. {3 - i} katset on alles.");


                }












            }












        }
    }
}
