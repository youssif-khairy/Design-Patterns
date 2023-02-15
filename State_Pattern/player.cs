using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_Pattern
{
    public class Player
    {
        private AbstractState _state = null;

        public Player(AbstractState state)
        {
            ChangeState(state); // set default state
        }

        public void ChangeState(AbstractState state)
        {
            _state = state;
            _state.SetState(this);
        }
        public void HandleMove1()
        {
            _state.state1();
        }
        public void HandleMove2()
        {
            _state.state2();
        }
    }
}
