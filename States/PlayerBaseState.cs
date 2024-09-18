using UnityEngine;
using RetroHorror;

namespace StateMachine
{
    public abstract class PlayerBaseState : BaseState
    {
        protected readonly PlayerController player;
        protected readonly Animator animator;

        protected readonly StateMachine stateMachine;

        protected PlayerBaseState(PlayerController player, Animator animator, StateMachine stateMachine)
        {
            this.player = player;
            this.animator = animator;
            this.stateMachine = stateMachine;
        }
        public override void FixedUpdate()
        {
        }

        public override void OnEnter()
        {
    
        }

        public override void OnExit()
        {
   
        }

        public override void Update()
        {

        }
    }
}
