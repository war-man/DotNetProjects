using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemcachedApp.Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                MemcachedHelper memcachedHelper = new MemcachedHelper();

                var key = Guid.NewGuid().ToString();
                var set = memcachedHelper.Insert(key, "abc", 1);
                var get = memcachedHelper.Get(key);
                Console.WriteLine(get);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Console.ReadKey();
        }
    }
}
