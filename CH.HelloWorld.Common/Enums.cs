using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH.HelloWorld.Common
{
    /// <summary>
    /// Dump all the common enums here
    /// </summary>
    public static class Enums
    {
        public enum WriteToSource
        {
            [Description("Console")]
            Console = 1,
            [Description("File")]
            File = 2,
            [Description("Database")]
            Database = 3,
        }

    }
}
