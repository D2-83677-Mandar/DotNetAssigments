namespace Assigmnt1_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Num1;
            int Num2;
            int choice;

          Num1 = Convert.ToInt32(args[0]);

            Num2 = Convert.ToInt32(args[1]);

            do
            {
                Console.WriteLine("calculator");
                Console.WriteLine("0 . Exit");
                Console.WriteLine("1 . Addtion");
                Console.WriteLine("2.subtraction");
                Console.WriteLine("3 .multiplaction");
                Console.WriteLine("4 .divison");
                Console.WriteLine("Enter the choice :");
                choice = Convert.ToInt32(Console.ReadLine());


                switch (choice)
                {
                    case 0:
                        Console.WriteLine("Thank you !!!!!1");
                        break;
                    case 1:
                        Console.WriteLine("Addition is " + (Num1 + Num2));
                        break;

                    case 2:
                        Console.WriteLine("Subtraction is " + (Num1 - Num2));
                        break;

                    case 3:
                        Console.WriteLine("Multiplaction  is " + (Num1 * Num2));
                        break;

                    case 4:
                        if (Num2 == 0)
                        {
                            Console.WriteLine("Can not  be a value zero ");
                        }
                        else
                            Console.WriteLine("Divsion is " + (Num1 / Num2));
                        break;
                    default:
                        Console.WriteLine("WRONG CHOCE ......");
                        break;


                }
                Console.ReadLine();

            } while (choice != 0);
        }
    }
}
