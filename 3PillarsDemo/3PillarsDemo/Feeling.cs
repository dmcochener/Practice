using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3PillarsDemo
{
    class Feeling
    {
        //Base Class and all sub classes will have a reply and farewell
        public string ReplyMessage = "Glad to hear things are going alright.";
        public string FarewellMessage = "Have a great day!";

        //Basic function for compiling messages to send to console,
        // need virtual keyword for polymorphism
        public virtual void Respond(InterfaceHandler _interface)
        {
            List<string> message = new List<string> { ReplyMessage, FarewellMessage };
            _interface.WriteTo(message);
            _interface.Exit();
        }
    }
}
