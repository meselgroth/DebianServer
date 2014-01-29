using Raspberry.IO.GeneralPurpose;
using System;

namespace RaspberryPiMorseCode
{
    public class GpioCaller:IDisposable
    {
        private GpioConnection connection;
        private OutputPinConfiguration led1;

        public GpioCaller()
        {
            led1 = ConnectorPin.P1Pin11.Output();
            connection = new GpioConnection(led1);
        }

        public void Light(string input)
        {
            if (input=="1")
            {
                Console.WriteLine("...turning light on");
                connection.Toggle(led1);
            }
            if (input == "0")
            {
                Console.WriteLine("...turning light off");
            }
        }

        public void Dispose()
        {
            connection.Close();
        }
    }
}
