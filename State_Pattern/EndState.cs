using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_Pattern
{
    public class EndState : AbstractState
    {
        public override void state1()
        {
            Console.WriteLine("End State 1");
        }

        public override void state2()
        {
            Console.WriteLine("Normal State 2");
        }
    }
}
