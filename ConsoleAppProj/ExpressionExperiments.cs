using System;
using System.Linq.Expressions;

namespace ConsoleAppProj
{
    public class ExpressionExperiments
    {

        delegate int del(int i);

        public void DoStuff()
        {
            del myDelegate = x => x * x;
            
            var j = myDelegate(5);
            
            Console.WriteLine($"Delegate returned {j}");

            Expression<del> myET = x => x * x;
            
            var body = myET.Body;
            Console.WriteLine($"Expression body is [{body}]");

            var name = myET.Name;
            Console.WriteLine($"Expression name is [{name}]");
            
            Console.WriteLine($"Expression type is [{myET.Type}]");
            Console.WriteLine($"Expression node type is [{myET.NodeType}]");
            
            var parameters = myET.Parameters;

            foreach (var parameter in parameters)
            {
                Console.WriteLine($"A parameter[{parameter}]");
            }
            
            


        }

    }
}