using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograming
{
    using System;

    public class FibonacciGenerator
    {
        private int previous;
        private int current;

        public FibonacciGenerator()
        {
            previous = 0;
            current = 1;
        }

        public int Next()
        {
            int next = previous + current;
            previous = current;
            current = next;
            return current;
        }
    }

}
