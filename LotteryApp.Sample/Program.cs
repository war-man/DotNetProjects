using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotteryApp.Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("抽奖开始...");
            string readValue = string.Empty;
            try
            {
                var data = SeedData.Data();
                var a = new Random().Next();
                //while (readValue?.ToLower() != "exit")
                //{
                //    readValue = Console.ReadLine();
                //}
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.ToString());
            }
            Console.WriteLine("抽奖结束...");
            Console.Read();
        }
    }
}
