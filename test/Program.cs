using System;

namespace TestingRefQuiz
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string test1 = "testingHello";
            string test2 = "testingHello2";
            var testString = new TestingString(test1,test2);
            var testRefString = new TestingRefString(ref test1, ref test2);

            test1 = "testingHello3";
            test2 = "testingHello24";
            Console.WriteLine(test1);
            Console.WriteLine(test2);
            Console.WriteLine(testString.testing);
            Console.WriteLine(testString.testing2);
            Console.WriteLine(testRefString.testing);
            Console.WriteLine(testRefString.testing2);

            Console.Read();
        }
    }
}
