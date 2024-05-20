
using Assigment8;


namespace Assigment10
{



   public class Superior :Employee
    {
        
        public Superior() {

            designation = "Supervisor";
        }
        private int _subordinates;

        public int subbordinates
        {
            get { return _subordinates; }
            set { _subordinates = value; }
        }

        public Superior(int subordinates)
        {
            _subordinates = subordinates;
        }

        public void accept()
        {
            base.acceptEmplyee();
            Console.WriteLine("Enter the no of subbordinates ");
            _subordinates = int.Parse(Console.ReadLine());

        }
        public void display()
        {
            base.displayemp();
            Console.WriteLine("subordinates is :" + _subordinates);
        }
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            Superior s = new Superior();
            s.accept();
            s.display();
        }
    }
}
