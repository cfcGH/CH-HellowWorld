using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CH.HelloWorld.Services.Interfaces;

namespace CH.HelloWorld.Services
{
    public class ConsoleWriter : IMessageWriter
    {
        /// <summary>
        /// Write a message to console
        /// </summary>
        /// <param name="message"></param>
        public void WriteMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
