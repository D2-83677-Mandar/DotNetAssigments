namespace EmployeeLib
{
    public class Date
    {
        private int _Day;
        private int _Month;
        private int _Year;

        public Date()
        {

        }
        public Date(int day, int month, int year)
        {
            _Day = day;
            _Month = month;
            _Year = year;
        }

        public void AcceptDate()
        {
            Console.WriteLine("Enter Day");
            _Day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Month");
            _Month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Year");
            _Year = Convert.ToInt32(Console.ReadLine());
            if (IsValid())
            {
                Console.WriteLine("Accepted");
            }
            else
            {
                Console.WriteLine("Date is INVALID !! RE-ENTER");
                AcceptDate();
            }
        }

        public void PrintDate()
        {
            if (IsValid())
            {
                Console.WriteLine(_Day.ToString() + "/" + _Month.ToString() + "/" + _Year.ToString());
            }
            else
            {
                Console.WriteLine("Date is not valid");
            }

        }
        public bool IsValid()
        {
            if (_Day < 1 || _Day > 31)
                return false;
            else if (_Month < 1 || _Month > 12)
                return false;
            else if (_Year < 1 || _Year > 9999)
                return false;
            else return true;

        }
        public int Day { get { return _Day; } set { _Day = value; } }
        public int Month { get { return _Month; } set { _Month = value; } }

        public int Year { get { return _Year; } set { _Year = value; } }

        public override string ToString() { return _Day.ToString() + "/" + _Month.ToString() + "/" + _Year.ToString(); }
    }
    public class Person
    {
        private string _Name;
        private bool _Gender;
        private Date _Birth;
        private string _Address;

        public Person()
        {
            Date d = new Date();
            _Birth = d;
        }

        public Person(string name, bool gender, Date birth, string address)
        {
            Date d = new Date(birth.Day, birth.Month, birth.Year);
            _Birth = d;
            _Name = name;
            _Gender = gender;
            _Address = address;

        }

        public void AcceptPerson()
        {
            Console.WriteLine("Enter Name");
            _Name = Console.ReadLine();
            Console.WriteLine("Enter Gender True or false");
            _Gender = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Enter For Date");
            _Birth.AcceptDate();
            Console.WriteLine("Enter Address");
            _Address = Console.ReadLine();

        }

        public void PrintPerson()
        {
            Console.WriteLine(ToString());
        }

        public string Address
        {
            get { return _Address; }

        }

        public Date Birth
        {
            get { return _Birth; }

        }

        public bool Gender
        {
            get { return _Gender; }

        }

        public string Name
        {
            get { return _Name; }
        }


        public override string ToString()
        {
            int year = DateTime.Parse(DateTime.Now.ToString()).Year;
            return "Name - " + _Name + " Gender - " + _Gender + " BirthDate - " + _Birth + " Address - " + _Address + " Age - " + (year - _Birth.Year);
        }

    }

    public class Employee : Person
    {
        private int _Id;
        private double _Salary;
        private string _Designation;
        private string _DepartmentType;
        private static int GenerateId = 1;

        public Employee()
        {
            this._Id = GenerateId;
            GenerateId = GenerateId + 1;
        }

        public Employee(int id, double salary, string designation, string departmentType)
        {
            this._Id = GenerateId;
            GenerateId = GenerateId + 1;
            _Salary = salary;
            _Designation = designation;
            _DepartmentType = departmentType;
        }

        public string DepartmentType
        {
            get { return _DepartmentType; }
            set { _DepartmentType = value; }
        }


        public string Designation
        {
            get { return _Designation; }
            set { _Designation = value; }
        }


        public double Salary
        {
            get { return _Salary; }
            set { _Salary = value; }
        }


        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        public void AcceptEmployee()
        {
            base.AcceptPerson();
            Console.WriteLine("Enter Salary");
            _Salary = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Designation");
            _Designation = Console.ReadLine();
            Console.WriteLine("Enter Dept Type");
            _DepartmentType = Console.ReadLine();

        }

        public void PrintEmployee()
        {
            base.PrintPerson();
            Console.WriteLine(_Id);
            Console.WriteLine(_Salary);
            Console.WriteLine(_Designation);
            Console.WriteLine(_DepartmentType);
        }

        public override string ToString()
        {
            return base.ToString() + " Id- " + _Id + " Salary- " + _Salary + " Designation- " + _Designation + " Department Type- " + _DepartmentType;
        }

    }
    public class Company
    {
        private string _Name;
        private string _Address;
        private LinkedList<Employee> _EmpList;
        private double _SalaryExpenses;

        public double SalaryExpenses
        {
            get { return _SalaryExpenses; }
            set { _SalaryExpenses = value; }
        }


        public LinkedList<Employee> EmpList
        {
            get { return _EmpList; }
            set { _EmpList = value; }
        }

        public string Address
        {
            get { return _Address; }
            set { _Address = value; }
        }

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public Company()
        {
            EmpList = new LinkedList<Employee>();
        }

        public Company(string name, string address, double salaryExpenses)
        {
            Name = name;
            Address = address;
            EmpList = new LinkedList<Employee>();

            SalaryExpenses = salaryExpenses;

        }

        public void AcceptCompany()
        {
            Console.WriteLine("Enter Name");
            _Name = Console.ReadLine();
            Console.WriteLine("Enter Address of Company");
            _Address = Console.ReadLine();
        }

        public void PrintCompany()
        {
            Console.WriteLine("Name : " + _Name);
            Console.WriteLine("Address : " + _Address);
            Console.WriteLine("Employyes Count : " + EmpList.Count);
            Console.WriteLine("Salary Expenses : " + _SalaryExpenses);
        }


        public void CalculateSalaryExpense()
        {
            double allSalary = 0;
            foreach (Employee emp in EmpList)
            {
                allSalary += emp.Salary;
            }
            SalaryExpenses = allSalary;
        }

        public void AddEmployee(Employee emp)
        {

            EmpList.AddLast(emp);
            CalculateSalaryExpense();
        }
        public bool RemoveEmployee(int id)
        {
            LinkedListNode<Employee> e = FindEmployee(id);
            if (e != null)
            {
                EmpList.Remove(e);
                CalculateSalaryExpense();
                return true;
            }
            return false;

        }

        public LinkedListNode<Employee> FindEmployee(int id)
        {
            for (var node = EmpList.First; node != null; node = node.Next)
            {
                if (node.Value.Id == id)
                {
                    return node;
                }
            }
            return null;
        }
    }

}
