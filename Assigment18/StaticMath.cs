using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question18
{
    public static class StaticMath<T>
    {
        public static T Add(T a, T b)
        {

            return (dynamic)a + (dynamic)b;
        }

        public static T Subtract(T a, T b) {

            return (dynamic)a - (dynamic)b;
        }

        public static T Multiply(T a, T b)
        {
            return (dynamic)a * (dynamic)b;
        }

        public static T Divide(T a, T b) { 
            return (dynamic)a / (dynamic)b;
        }
    }
}
