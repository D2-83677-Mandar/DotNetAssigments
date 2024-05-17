using System.Runtime;

namespace Assigment8
{


    public class person
    {
     
   

        private int _age;

        public person(int age, string name)
        {
            _age = age;
            _name = name;
        }

        public int age
        {
            get { return _age; }
            set { _age = value; }
        }

        private string _name ;

        public string name
        {
            get { return _name ; }
            set { _name  = value; }
        }
         

        public person() { 
        
        }


       public void acceptperson()
        {

            Console.WriteLine("Enter the Name ");
            name = Console.ReadLine();
            Console.WriteLine("Enter the age ");
            age = int.Parse(Console.ReadLine());

        }

        public void Displayperson()
        {
            Console.WriteLine("name "+name);
            Console.WriteLine("age " + age);

        }

    
        public override string ToString()
        {
            return name  +  age
                ;
        }


    }



    public class DepartmentType
    {
        public const string ENGINEERING = "Engineering";
        public const string SALES = "Sales";
        public const string MARKETING = "Marketing";
        public const string FINANCE = "Finance";
    }




    public class Employee : person
    {
       


        private int _id;
 

        public int id
        {
            get { return _id; }
            set { _id = value; }
        }

        private DepartmentType _dept;

        public  DepartmentType dept
        {
            get { return _dept; }
            set { _dept = value; }
        }

        private string _designation;

        public string designation
        {
            get { return _designation; }
            set { _designation = value; }
        }

        private double _salary;

      
        public Employee(DepartmentType dept, double salary ,string designamtion )
        {
         
            _designation = designamtion;
            _dept = dept;
            _salary = salary;
            _id = gernrateid++;
        }

        public double salary
        {
            get { return _salary; }
            set { _salary = value; }
        }

        private static int gernrateid = 1;



        public Employee() {

            _id = gernrateid++;
    


        }


      public  void acceptEmplyee()
        {
            base.acceptperson();


           

            Console.WriteLine("Enter department (ENGINEERING, SALES, MARKETING, FINANCE):");
            string deptInput = Console.ReadLine();
          //  _dept = (DepartmentType)Enum.Parse(typeof(DepartmentType), deptInput, true);

            Console.WriteLine("enter the Designation");
            _designation = Console.ReadLine();
            Console.WriteLine("Enter the Salary ");
            _salary = double.Parse(Console.ReadLine());

        }


        public void displayemp()
        {
            base.Displayperson();
            Console.WriteLine("id -  " + _id);
            Console.WriteLine("department type " + _dept);
            Console.WriteLine("Designation is :" + _designation);
            Console.WriteLine("salary is :" + _salary);
        }

        public override string ToString()
        {
            return base.ToString() + dept + designation + salary ;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            Employee e = new Employee();
            e.acceptEmplyee();
            e.displayemp();
            Employee e1 = new Employee();
            e1.acceptEmplyee();
            e1.displayemp();

        }
    }
}
