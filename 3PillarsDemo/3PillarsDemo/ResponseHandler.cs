using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3PillarsDemo
{
    class ResponseHandler
    {
        public Feeling Today;
        public ResponseHandler(char response)
        {

            if (response== 'O' || response == 'o')
                Today = new FeelingOk();
            else if (response == 'B' || response == 'b')
                Today = new FeelingBad();
            else if (response == 'G' || response == 'g')
                Today = new FeelingGreat();
            else
                Today = new Feeling();
        }
    }
}
