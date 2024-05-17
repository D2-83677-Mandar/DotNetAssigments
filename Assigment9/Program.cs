using Assigment8;






namespace assigment9
{



    class manger : Employee
    {

        public manger(double bonus)
        {
                this._bonus = bonus;

        }
        private double _bonus;

        public double bonus
        {
            get { return _bonus; }
            set { _bonus = value; }
        }


      public  void accptman()
        {
            base.displayemp();

            Console.WriteLine("Enter the bonus :");
            _bonus = double.Parse(Console.ReadLine());


        }


        public override string ToString()
        {
            return base.ToString();
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
