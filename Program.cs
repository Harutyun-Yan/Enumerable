using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerable
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> res = new List<int> { 5, 28, 12, 6, -6, -36, 79 };
            List<int> ress = new List<int>();

            var test1 = res._First();
            var test2 = ress._First();
            var test3 = res.PlusChange(10);
            var test4 = ress.PlusChange(10);
            var test5 = res.MinusChange(10);
            var test6 = res.MultyChange(10);
            var test7 = res.DivChange(0);
        }
    }
}
