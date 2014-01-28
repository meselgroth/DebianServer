using System;

namespace RaspberryPiMorseCode
{
    public class GpioCaller
    {

        public void Light(string input)
        {
            if (input=="1")
            {
                Console.WriteLine("...turning light on");
            }
            if (input == "0")
            {
                Console.WriteLine("...turning light off");
            }
        }
    }
}
