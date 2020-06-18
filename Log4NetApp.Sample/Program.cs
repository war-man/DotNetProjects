using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Log4NetApp.Sample.Log4NetHelper;

namespace Log4NetApp.Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start...");

            //注册log4net
            Logger.Instance().Register();
            Logger.Info("hello word...");

            Console.WriteLine("End...");
            Console.ReadKey();
        }
    }
}
