namespace ConsoleAppProj
{
    using System;

    public class UriTester
    {
        public static void DoStuff()
        {
            Console.WriteLine("Hello from UriTester!");

            const string testUrl = @"http://localhost:5000/sample/data?sample-arg=sample-value";

            var inputUri = new Uri(testUrl);

            var baseUri = new Uri(inputUri.GetLeftPart(UriPartial.Authority));

            var relativeUri = baseUri.MakeRelativeUri(inputUri);
            
            Console.WriteLine($"Original string:{testUrl}");
            Console.WriteLine($"Base URI:{baseUri}");
            Console.WriteLine($"Relative URI:{relativeUri}");
        }
    }
}