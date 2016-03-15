using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum_ex25
{
    class Process
    {
        public enum State
        {
            Stopped,
            Running,
            Pause
        }

        private State _currentState;

        public State CurrentState
        {
            get
            {
                return _currentState;
            }
        }

        public void Start()
        {
            if (_currentState != State.Running)
                _currentState = State.Running;
        }

        public void Stop()
        {
            if (_currentState == State.Running)
                _currentState = State.Stopped;
        }

        public void Pause()
        {
            if (_currentState == State.Running)
                _currentState = State.Pause;
        }
    }
}
