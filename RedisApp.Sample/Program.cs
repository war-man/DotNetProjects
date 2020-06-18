using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedisApp.Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("End....");

            var redisHelper = new RedisHelper();

            var key = Guid.NewGuid().ToString();

            //var s = redisHelper.StringSet(key, "123");
            //Console.WriteLine(s ? "OK" : "No");

            var token = Environment.MachineName;
            var s = redisHelper.LockTake(key, token, TimeSpan.FromMinutes(1));
            if (s)
            {
                try
                {
                    Console.WriteLine("Working..........");
                }
                finally
                {
                    redisHelper.LockRelease(key, token);
                }
            }

            Console.WriteLine("End....");
            Console.ReadKey();
        }
    }
}
