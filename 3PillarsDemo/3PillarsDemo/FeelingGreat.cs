using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3PillarsDemo
{
    //shows ease of inheritance, just change one property
    class FeelingGreat :Feeling
    {
        public FeelingGreat()
        {
            ReplyMessage = "That's fantastic!";
        }
    }
}
