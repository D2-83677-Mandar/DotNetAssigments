using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question18
{
    public class InstanceMath<T> 
    {
        public T Add(T a, T b)
        {
            return (dynamic)a + (dynamic)b;
        }

        public T Subtract(T a, T b)
        {
            return (dynamic)a - (dynamic)b;
        }

        public T Multiply(T a, T b)
        {
            return (dynamic)a * (dynamic)b;
        }

        public T Divide(T a, T b)
        {
            return (dynamic)a / (dynamic)b;
        }
    }
}
