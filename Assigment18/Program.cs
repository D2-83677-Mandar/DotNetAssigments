namespace question18
{
    public delegate T MathOperation<T> (T a, T b);
    public class Program
    {
        static void Main(string[] args)
        {
            MathOperation<int> op1 = new MathOperation<int>(StaticMath<int>.Add);
            Console.WriteLine("Static Sum: " + op1(10, 5));

            op1 = new MathOperation<int>(StaticMath<int>.Subtract);
            Console.WriteLine("Static Subtract: " + op1(10, 5));

            op1 = new MathOperation<int>(StaticMath<int>.Multiply);
            Console.WriteLine("Static Multiply: " + op1(10, 5));

            op1 = new MathOperation<int>(StaticMath<int>.Divide);
            Console.WriteLine("Static Divide: " + op1(10, 5));

            MathOperation<int> multicastOp = new MathOperation<int>(StaticMath<int>.Add);
            multicastOp += StaticMath<int>.Subtract;
            multicastOp += StaticMath<int>.Multiply;
            multicastOp += StaticMath<int>.Divide;

            foreach (MathOperation<int> op in multicastOp.GetInvocationList())
            {
                Console.WriteLine(op.Method.Name + ": " + op(10, 5));
            }



            InstanceMath<int> instanceMath = new InstanceMath<int>();
            MathOperation<int> op2 = new MathOperation<int>(instanceMath.Add);
            Console.WriteLine("\nInstance Sum: " + op2(10, 5));

            op2 = new MathOperation<int>(instanceMath.Subtract);
            Console.WriteLine("Instance Subtract: " + op2(10, 5));

            op2 = new MathOperation<int>(instanceMath.Multiply);
            Console.WriteLine("Instance Multiply: " + op2(10, 5));

            op2 = new MathOperation<int>(instanceMath.Divide);
            Console.WriteLine("Instance Divide: " + op2(10, 5));



            MathOperation<int> instanceMulticastOp = new MathOperation<int>(instanceMath.Add);
            instanceMulticastOp += instanceMath.Subtract;
            instanceMulticastOp += instanceMath.Multiply;
            instanceMulticastOp += instanceMath.Divide;

            foreach (MathOperation<int> op in instanceMulticastOp.GetInvocationList())
            {
                Console.WriteLine(op.Method.Name + ": " + op(10, 5));
            }
        }
    }
}
