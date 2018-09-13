using System;
using System.Linq.Expressions;

namespace ConsoleAppProj
{
    public static class ExpressionExperiments
    {

        delegate int del(int i);

        public static void DoStuff()
        {
            int MyDelegate(int x) => x * x;

            var j = MyDelegate(5);
            
            Console.WriteLine($"Delegate returned {j}");

            Expression<del> myEt = x => x * x;
            
            var body = myEt.Body;
            Console.WriteLine($"Expression body is [{body}]");

            var name = myEt.Name;
            Console.WriteLine($"Expression name is [{name}]");
            
            Console.WriteLine($"Expression type is [{myEt.Type}]");
            Console.WriteLine($"Expression node type is [{myEt.NodeType}]");
            
            var parameters = myEt.Parameters;

            foreach (var parameter in parameters)
            {
                Console.WriteLine($"A parameter[{parameter}]");
            }
            
        }

        private static void DoSomethingWithAFunc<T, TProperty>(Func<T, TProperty> func)
        {
            
        }

    }
}