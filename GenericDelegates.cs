using System;
using System.Collections.Generic;
using System.Text;

namespace DelegatesExample
{
    public class GenericDelegates
    {
        public void Action(Action action)
        {
            action();
        }

        public void ActionWithParameter(Action<string> action)
        {
            action(obj: "Action With Parameter executed");
        }

        public bool FuncThatOnlyReturns(Func<bool> func)
        {
            return func();
        }
        public bool FuncThatReturnAndNeedsParameter(Func<string, bool> func)
        {
            return func(arg: "Func That Returns And Needs Parameter executed");
        }
    }
}
