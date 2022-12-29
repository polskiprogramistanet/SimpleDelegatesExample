using System;

namespace DelegatesExample
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var presentation = new GenericDelegates();

            presentation.Action(() => Console.WriteLine("Action executed"));
            presentation.ActionWithParameter((param) => Console.WriteLine(param));
            presentation.FuncThatOnlyReturns(() =>
            {
                Console.WriteLine("Func That Only Return");
                return true;
            });
            presentation.FuncThatReturnAndNeedsParameter((param) =>
            {
                Console.WriteLine(param);
                return true;
            });
        }

        
    }
}
