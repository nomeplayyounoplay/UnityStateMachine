using UnityEngine;

namespace StateMachine
{
    public abstract class BaseState : IState
    {
        public abstract void OnEnter();
        public abstract void Update();
        public abstract void FixedUpdate();
        public abstract void OnExit();
    }
}
