using Microsoft.Owin.Hosting;
using System;
using System.Net.Http;

namespace RaspberryPiMorseCode
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = string.Empty;
            Console.WriteLine("Welcome to morse code");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Type w to run Restful Webserver");
            Console.WriteLine("Type c to run Command Line Interface");
            Console.WriteLine("Type x to run webserver");
            input = Console.ReadLine();

            switch (input)
            {
                case "w":
                    RunWebserver();
                    break;
                case "c":
                    RunCLI();
                    break;
            }
        }

        private static void RunWebserver()
        {
            string baseAddress = "http://localhost:9000/";

            // Start OWIN host 
            using (WebApp.Start<Startup>(url: baseAddress))
            {
                // Create HttpCient and make a request to api/values 
                HttpClient client = new HttpClient();

                var response = client.PutAsJsonAsync(baseAddress + "api/MorseCode","1").Result;

                Console.WriteLine(response);
                Console.WriteLine(response.Content.ReadAsStringAsync().Result);
            }

            Console.ReadLine(); 
        }

        private static void RunCLI()
        {
            var input = string.Empty;
            Console.WriteLine("Welcome to morse code");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Type x to exit");
            Console.WriteLine("Type 1 to turn led on");
            Console.WriteLine("Type 0 to turn led off");

            using (var gpioCaller = new GpioCaller())
            {
                while (input != "x")
                {
                    input = Console.ReadLine();

                    gpioCaller.Light(input);
                }
            }
        }
    }
}
