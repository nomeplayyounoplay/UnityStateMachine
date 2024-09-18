using System;

namespace StateMachine
{
    public class FuncPredicate : IPredicate
    {
        readonly Func<bool> func;

        public FuncPredicate(Func<bool> func)
        {
            this.func = func;
        }
        public bool IsConditionMet() => func.Invoke();
    }

}
