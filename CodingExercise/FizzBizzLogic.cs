using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingExercise
{
    public class FizzBizzLogic
    {
        public int FizzBizz(int val)
        {
            if (val % 15 == 0)
                return 15;
            if (val % 5 == 0)
                return 5;
            if (val % 3 == 0)
                return 3;                        
            else
                return -1;            
        }
    }
}
