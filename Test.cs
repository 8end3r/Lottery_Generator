using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Test
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool IsTrueOrFalse { get; set; }

        public void TestMethod(int age)
        {
            age = Age;

            for(int i = 0; i <= age; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
