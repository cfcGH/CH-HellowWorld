using CH.HelloWorld.Services;
using CH.HelloWorld.Services.Interfaces;

namespace CH.HelloWorld.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: We can use a dependency injection tool like Unity or Autofac to inject this dependency for us
            //rather than "newing" it here creating a concrete dependency between this class and ConsoleWriter 
            //So everytime the console app client refers  IMessageWriter the DI container can supply ConsoleWriter
            IMessageWriter consoleWriter = new ConsoleWriter();
            consoleWriter.WriteMessage("Hello World");

            System.Console.ReadLine();
        }
    }
}
