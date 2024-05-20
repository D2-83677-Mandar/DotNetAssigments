using Assigment8;

namespace Assigment11
{
    public class WageEmp:Employee
    {
        private int _housrs;
        private int _rate;
        int result;
        public int rate
        {
            get { return _rate; }
            set { _rate = value; }
        }


        public int hours
        {
            get { return _housrs; }
            set { _housrs = value; }
        }


        public WageEmp()
        {
            designation = "Wage";

        }

        public WageEmp(int housrs, int rate)
        {
            _housrs = housrs;
            _rate = rate;
        }

        public int calculatewage(int rate, int hrs)
        {
            result = rate * hrs;
            return result;

        }


        public void accept()
        {
            base.acceptEmplyee();
            Console.WriteLine("Enter the Hrs :");
            hours = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the rate :");
            rate = int.Parse(Console.ReadLine());
            calculatewage(hours, rate);

        }

      

        public void displaywage()
        {
            base.displayemp();
            Console.WriteLine("rate :" + rate);
            Console.WriteLine("hrs : " + hours);

            Console.WriteLine( "total Wage of employee "+result);
        }


    }




    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            WageEmp emp = new WageEmp();
            emp.accept();
            emp.displaywage();
        }
    }
}
