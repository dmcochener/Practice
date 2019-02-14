using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3PillarsDemo
{
    //shows ease of inheritance, just change one property during construction
    class FeelingOk: Feeling
    {
        public FeelingOk()
        {
            FarewellMessage = "Hope your day gets better and better!";
        }
        
    }
}
