using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerable
{
    public static class Extention
    {
        public static IEnumerable<int> _First(this IEnumerable<int> source)
        {
            if (source == null)
                throw new ArgumentException();
            foreach (var item in source)
            {
                yield return item;
                yield break;
            }
        }
        public static IEnumerable<int> PlusChange(this IEnumerable<int> source, int value)
        {
            if (source == null)
                throw new ArgumentException();
            foreach (var item in source)
            {
                yield return (item + value);
                yield break;
            }
        }
        public static IEnumerable<int> MinusChange(this IEnumerable<int> source, int value)
        {
            if (source == null)
                throw new ArgumentException();
            foreach (var item in source)
            {
                yield return (item - value);
                yield break;
            }
        }

        public static IEnumerable<int> MultyChange(this IEnumerable<int> source, int value)
        {
            if (source == null)
                throw new ArgumentException();
            foreach (var item in source)
            {
                yield return (item * value);
                yield break;
            }
        }
        public static IEnumerable<int> DivChange(this IEnumerable<int> source, int value)
        {
            if (source == null && value == 0)
                throw new ArgumentException();
            foreach (var item in source)
            {
                yield return (item / value);
                yield break;
            }
        }
    }
}

