using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageOperations
{
    internal class ErrorLogger
    {
        public void log(string error)
        {
            File.WriteAllText("D:\\Programowanie\\C# projects\\Logs\\ErrorsLogs.txt", error);
        }
    }
}
