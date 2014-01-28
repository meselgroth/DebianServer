using Raspberry.IO.GeneralPurpose;
using System;

namespace RaspberryPiMorseCode
{
    public class GpioCaller
    {
        public void Light(string input)
        {
            var led1 = ConnectorPin.P1Pin11.Output();
            var connection = new GpioConnection(led1);

            if (input=="1")
            {
                Console.WriteLine("...turning light on");
                connection.Toggle(led1);
            }
            if (input == "0")
            {
                Console.WriteLine("...turning light off");
            }
            connection.Close();
        }
    }
}
