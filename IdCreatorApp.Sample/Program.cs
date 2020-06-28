using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace IdCreatorApp.Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            IdCreator c = new IdCreator(0, 16);
            var id = c.Create();

            Console.WriteLine(id);
            Console.ReadKey();
        }
    }
}
