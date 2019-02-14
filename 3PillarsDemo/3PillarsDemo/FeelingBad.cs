using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3PillarsDemo
{
    //demonstrates polymorphism with addition of joke implementation
    class FeelingBad : Feeling
    {
        public FeelingBad()
        {

            ReplyMessage = "Sorry to hear things aren't going your way";
        }

        public override void Respond(InterfaceHandler _interface)
        {
            List<string> First = new List<string> { ReplyMessage, "Would a joke cheer you up?", "Press Y for Yes and N for No" }; _interface.WriteTo(First);
            Random rand = new Random();
            TellJoke(rand, _interface);
            List<string> Final = new List<string> { "That's a no to a joke.", FarewellMessage };
            _interface.WriteTo(Final);
            _interface.Exit();
        }

        public void TellJoke(Random _rand, InterfaceHandler _interface)
        {
            char input = _interface.GetResponse();
            if (input == 'Y' || input == 'y')
            {
                List<string> Joke = GetJoke(_rand);
                Joke.Add("Would you like to hear another joke?");
                _interface.WriteTo(Joke);
                TellJoke(_rand, _interface);
            }

        }

        protected List<string> GetJoke(Random _rand)
        {
            List<string>[] Jokes = new List<string>[] {
                new List<string> { "Sometimes I tuck my knees into my chest and lean forward.", "That's just how I roll!" },
                new List<string> { "Did you hear about the crook that stole a calendar?", "He got twelve months." },
                new List<string> { "I've just written a song about tortillas...", "Actually, it's more of a rap." } };

            //Didn't seem very random when I just did the next of Jokes.length, could use more jokes too...
            int index = _rand.Next(1000) % Jokes.Length;

            return Jokes[index];
        }

    }
}
