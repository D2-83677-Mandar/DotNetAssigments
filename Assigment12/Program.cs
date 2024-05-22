using System.Collections.Generic;
using System.Xml.Linq;
using Assigment12;
using Assigment8;


namespace Assigment12
{
    public class Company {

        private string _name ;
        private string _Address;
        private LinkedList<Employee> _emplist;
        private double _SalaryExpenses;

        public double salaryexpnaces
        {
            get { return _SalaryExpenses; }
            set { _SalaryExpenses = value; }
        }


        public LinkedList<Employee> emplist
        {
            get { return _emplist; }
            set { _emplist = value; }
        }


        public string address
        {
            get { return _Address; }
            set { _Address = value; }
        }


        public string name
        {
            get { return _name ; }
            set { _name  = value; }
        }
        public Company()
        {
            _emplist = new LinkedList<Employee>();
        }

        public Company(string name, string address,  double salaryExpenses)
        {
            _name = name;
            _Address = address;
            _emplist = new LinkedList<Employee>();
            _SalaryExpenses = salaryExpenses;
        }



        public void acceptcompnat()
        {
            Console.WriteLine("enter the Name of company :");
            _name = Console.ReadLine();
            Console.WriteLine("enter the Adress  of company :");
            _Address = Console.ReadLine();
        }

        public void PrintCompany()
        {
            Console.WriteLine("Name : " + _name);
            Console.WriteLine("Address : " + _Address);
            Console.WriteLine("Employyes Count : " + _emplist.Count);
            Console.WriteLine("Salary Expenses : " + _SalaryExpenses);
        }
        public void CalculateSalaryExpense()
        {
            double allSalary = 0;
            foreach (Employee emp in emplist)
            {
                allSalary += emp.salary;
            }
            salaryexpnaces = allSalary;
        }

        public void Addemployee(Employee emp)
        {
            emplist.AddFirst(emp);
            CalculateSalaryExpense();
        }

        public bool RemoveEmployee(int id) 
        {
            LinkedListNode<Employee> e =  findemployee(id);
            if (e != null)
            {
                emplist.Remove(e);
                CalculateSalaryExpense();
                return true;
            }
            return false;
         
        }

        public LinkedListNode <Employee> findemployee(int id)
        {

            for(var node = emplist.First; node != null; node = node.Next)
            {
                if (node.Value.id == id )
                {
                    return node;
                    
                }
            }
            return null;
        }



       
    

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Company com = new Company();
            Console.WriteLine("Enter company infot=r mation");
            com.acceptcompnat();
            int choise = 0;



        // LinkedList<Employee> emplist = new LinkedList<Employee>();
         

        do
        {
            Console.WriteLine("MENU ");
            Console.WriteLine("0.EXIT ");
            Console.WriteLine("1.Add EMplyee ");
            Console.WriteLine("2.Remove Employee ");
            Console.WriteLine("3.find Employee ");
            Console.WriteLine("4.print All Employee ");
                Console.WriteLine("Press 5 to Display companys Salary Expenses");
                Console.WriteLine("Press 6 to Display companys info");
                Console.WriteLine("Enter the choice :");
            choise = Convert.ToInt32(Console.ReadLine());






        



            switch (choise)

            {

                case 0:

                    Console.WriteLine("thank You ");
                    break;

                case 1:
                        Employee emp = new Employee();
                        // com.Acceptcompnay();
                     emp.acceptEmplyee();
                      com.Addemployee(emp);
                        Console.WriteLine("employee Added succesfully ");
                //list.AddFirst(e);
                  //  list.AddLast(com);
                    break;
                case 2:

                        Console.WriteLine("Enter the id of employee you wwant to remove :");
                        int id = Convert.ToInt32(Console.ReadLine());
                        if(com.RemoveEmployee(id))
                        {
                            Console.WriteLine("Employee removed");
                        }
                        else
                        {
                            Console.WriteLine("some error ");
                        }

                        break;


                        case 3:
                        Console.WriteLine("enter the id top find :");
                        int findid = Convert.ToInt32(Console.ReadLine());
                        LinkedListNode<Employee> e = com.findemployee(findid);
                        if(e!= null)
                        {
                            e.Value.displayemp();

                        }
                        break;


                    case 4:
                        foreach (Employee emp1 in com.emplist)
                        {
                            emp1.displayemp();
                        }
                        break;

                    case 5:
                        Console.WriteLine("salary expancies :" + com.salaryexpnaces);
                        break;

                    case 6:
                        com.PrintCompany();
                        break;
                default:
                    break;
            }


        } while (choise!=0);

             
             
        }
    }
}
