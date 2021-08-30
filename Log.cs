using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelDataHandler
{
    public static class Log
    {
        public static List<string> listMessages { get; set; } = new List<string>();

        public static void Write(string message)
        {
            listMessages.Add(message + "\r\n\r\n");
        }
    }
}
