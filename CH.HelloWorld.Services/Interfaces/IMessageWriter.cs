using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH.HelloWorld.Services.Interfaces
{
    /// <summary>
    /// Define a contract to write a message, any source that needs the message to be written needs to implement this interface.
    /// </summary>
    public interface IMessageWriter
    {
        void WriteMessage(String message);

    }
}
