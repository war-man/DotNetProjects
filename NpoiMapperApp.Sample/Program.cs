using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npoi.Mapper;

namespace NpoiMapperApp.Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                PersonTest.Test2();
                Console.WriteLine("执行完成");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            Console.Read();
        }
    }


}
