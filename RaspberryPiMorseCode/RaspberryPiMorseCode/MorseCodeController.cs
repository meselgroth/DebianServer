using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace RaspberryPiMorseCode
{
    public class MorseCodeController:ApiController
    {
        private GpioCaller _gpioCaller;

        public MorseCodeController()
        {
            Console.WriteLine("..connecting GPIO");
            _gpioCaller = new GpioCaller();
        }

        // PUT /MorseCode/1
        public void Put([FromBody]string value)
        {
            _gpioCaller.Light(value);
        } 
    }
}
