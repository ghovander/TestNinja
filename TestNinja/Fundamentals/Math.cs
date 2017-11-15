using System.Collections.Generic;

namespace TestNinja.Fundamentals
{
    public class Math
    {

        //1 execution path means that at a minimum 1 set of values must be used to verify output.
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Max(int a, int b)
        {
            return (a > b) ? a : b;
        }

        public IEnumerable<int> GetOddNumbers(int limit)
        {
            for (var i = 0; i <= limit; i++)
                if (i % 2 != 0)
                    yield return i;
        }
    }
}