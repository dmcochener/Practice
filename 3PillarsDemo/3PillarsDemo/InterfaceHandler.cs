using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3PillarsDemo
{
    //While this class just repackages most of the console functionality,
    // by separating it into another class, the code could easily be reworked
    // to work with another user interface by just re-writting this class
    class InterfaceHandler
    {
        
        // Basic Greeting to dsiplay when starting the program
        public void Greeting()
        {
            Console.WriteLine("Hello! How are you feeling today?");
            Console.WriteLine("Type 'O' for OK, 'G' for Great, and 'B' for Bad");
        }
            

        //Basic Function to write several lines to the console, written with generics to handle many types of input
        public void WriteTo(IEnumerable<string> message)
        {
            //Insert Break between any input and next write line
            Console.WriteLine(" ");
   
            foreach (var line in message)
            {
                Console.WriteLine(line);
            }
        }

        //Gets single key entry response from console
        public char GetResponse()
        {
            return Console.ReadKey().KeyChar;
        }

        //When program is finished, leaves console in place until user exits
        public void Exit()
        {
            Console.WriteLine("Press any key to exit.");
            Console.Read();
        }
    }
}
