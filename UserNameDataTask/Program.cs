using System;

namespace UserNameDataTask
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajalt sisestada eesnime;
            //programm küsib kasutajalt sisestada numbrid 1-3;
            //kui kasutaja sisestab '1', siis kuvatakse kasutaja eesnime tagurpidi;
            //kui kasutaja valib '2', siis kuvatakse kasutaja eesnime esimene täht;
            //kui kasutaja valib '3', siis kuvatakse kasutaja eesnime pikkus.

            Console.WriteLine("Sisesta oma eesnimi:");
            string userName = Console.ReadLine();

            Console.WriteLine("Vali number ühest kolmeni:");
            char userNumber = Convert.ToChar(Console.ReadLine());


            switch (userNumber)
            {
                case '1':
                    UserNameReversed(userName);
                    break;
                case '2':
                    UserNameFirstChar(userName);
                    break;
                case '3':
                    UserNameLength(userName);
                    break;
            }
        }

        public static void UserNameReversed(string userInput)
        {
            Console.Write("Sinu nimi tagurpidi on: ");
            for (int i = userInput.Length - 1; i >= 0; i--)
            {
                Console.Write(userInput[i]);
            }
        }

        public static void UserNameFirstChar(string userInput)
        {
            Console.WriteLine($"Sinu nime esimene täht on: {userInput[0]}");
        }

        public static void UserNameLength(string userInput)
        {
            Console.WriteLine($"Sinu nime pikkus on: {userInput.Length} sümbolit.");
        }
    }
}