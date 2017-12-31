using CH.HelloWorld.Common;
using CH.HelloWorld.Services;
using CH.HelloWorld.Services.Interfaces;
using System;
using System.Configuration;
using static CH.HelloWorld.Common.Enums;

namespace CH.HelloWorld.Console
{
    class Program
    {
        private const string WRITE_TO = "WriteToSource";
        private static string _writeTo;
        static void Main(string[] args)
        {
            _writeTo = ConfigurationManager.AppSettings[WRITE_TO];
            if (Convert.ToInt32(_writeTo) == Convert.ToInt32(WriteToSource.Console))
            {
                IMessageWriter consoleWriter = new ConsoleWriter();
                consoleWriter.WriteMessage("Hello World");
            }
            System.Console.ReadLine();

            //-------------------------------Potential enhancements-----------------------------------------------
            //1. We can use a dependency injection tool like Unity or Autofac to inject this dependency for us
            //   rather than "newing" it here creating a concrete dependency between this class and ConsoleWriter 
            //2. Too much noise in reading the config values, this can be moved to an IConfigurationService
            //   and use DI to inject the dependency
            //----------------------------------------------------------------------------------------------------
        }
    }
}
