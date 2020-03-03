using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;

namespace Nlog使用
{
    class Program
    {

        static void Main(string[] args)
        {
            var loggerHelper=new LoggerHelper();
            loggerHelper.Info("这他妈是啥啊");
        }
    }
}
