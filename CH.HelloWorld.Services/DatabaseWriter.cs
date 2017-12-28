using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CH.HelloWorld.Services.Interfaces;

namespace CH.HelloWorld.Services
{
    public class DatabaseWriter : IMessageWriter
    {
        /// <summary>
        /// Write a message to DB
        /// </summary>
        /// <param name="message"></param>
        public void WriteMessage(string message)
        {
           //TODO: Use an EF Datacontext to write the data in the message variable to  table Messages
        }
    }
}
