namespace Assigment41
{
    public struct student
    {
        private string _Name;

        public string name
        {
            get { return _Name; }
            set { _Name = value; }
        }


        private int _age;

        public int age
        {
            get { return _age; }
            set { _age = value; }
        }

        private bool _gender;

        public bool gender
        {
            get { return _gender; }
            set { _gender = value; }
        }

        private int _std;

        public int std
        {
            get { return _std; }
            set { _std = value; }
        }

        private char _div;

        public char div
        {
            get { return _div; }
            set { _div = value; }
        }

        private double _marks;

        public double marks
        {
            get { return _marks; }
            set { _marks = value; }
        }

        public student(string name ,bool gender , int age , int std , char div ,double marks)
        {
        _Name = name;
            _age = age;
            _gender = gender;
            _std = std;
            _div = div;
            _marks = marks;


        }

        public student() { }

        public void accpetdetails()
        {
            Console.WriteLine("deatils are ");
            Console.WriteLine("Enter  Name is ");
            name = Console.ReadLine();
            Console.WriteLine("Enter the age :");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the gender ");
            gender =  bool.Parse(Console.ReadLine());
            Console.WriteLine("enter the std ");
            std = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the div ");
            div= char.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Marks ");
            marks = Convert.ToDouble(Console.ReadLine());


             

        }
        public void displaydetails()
        {
            Console.WriteLine("name is :" + name);
            Console.WriteLine("age is : " + age);
            Console.WriteLine("std is :"+ std);
            Console.WriteLine("div is :" + div);
            Console.WriteLine("marks is " + marks);

        }





    }
    internal class Program
    {
       
        static void Main(string[] args)
        {
            student s1 = new student();
            s1.accpetdetails();
            s1.displaydetails();
        }
    }
}
