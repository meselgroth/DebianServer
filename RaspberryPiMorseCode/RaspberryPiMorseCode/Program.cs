﻿using System;

namespace RaspberryPiMorseCode
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = string.Empty;
            Console.WriteLine("Welcome to morse code");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Type x to exit");
            Console.WriteLine("Type 1 to turn led on");
            Console.WriteLine("Type 0 to turn led off");

            while (input != "x")
            {
                input = Console.ReadLine();

                var gpioCaller = new GpioCaller();
                gpioCaller.Light(input);
            }
        }
    }
}