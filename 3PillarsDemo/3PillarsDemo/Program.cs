using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3PillarsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var Interface = new InterfaceHandler();
            //Greet user
            Interface.Greeting();
            //Get response from user
            char response = Interface.GetResponse();
            //Respond to user, can use any subclass of Feeling
            var Handler = new ResponseHandler(response);
            Feeling Today =  Handler.Today;
            Today.Respond(Interface);
        }
    }
}
