using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_Pattern
{
    public class NormalState : AbstractState
    {

        public override void state1()
        {
            Console.WriteLine("Normal State 1");
            //then call another state directly
            player.ChangeState(new NormalState());
        }

        public override void state2()
        {
            Console.WriteLine("Normal State 2");
        }
    }
}
