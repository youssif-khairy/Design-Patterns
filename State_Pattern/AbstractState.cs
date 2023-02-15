using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_Pattern
{
    public abstract class AbstractState
    {
        protected Player player = null;

        //set state should by setting new player with it's new state
        public void SetState(Player p)
        {
            player = p;
        }
        public abstract void state1();
        public abstract void state2();
    }
}
