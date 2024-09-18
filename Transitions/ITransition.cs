namespace StateMachine
{
    public interface ITransition
    {
        IState TransitionTo{get;}
        IPredicate Condition{get;}
    }

}
