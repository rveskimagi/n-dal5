using System;

namespace LoginValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            String Username;
            String Password;

            Password = "admin1234"; 
            Username = "admin";

            int totalAttempts = 3;

            Console.WriteLine("Sisesta kasutajatunnus:");
            string userName = Console.ReadLine();
            Console.WriteLine("Sisesta salasõna:");
            string userPassword = Console.ReadLine();

            if (userName != "admin" || userPassword != "admin1234")
            {
                Console.WriteLine("Vale kasutajatunnus või salasõna. Proovi uuesti.");
            }
            else
            {
                Console.WriteLine("Tere tulemast!");
            }



        }
    }
}