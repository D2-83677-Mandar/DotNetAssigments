using EmployeeLib;


namespace Assigment14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Company comp = new Company();
            Console.WriteLine("Enter Company's Information");
            comp.AcceptCompany();
            int choice;
            do
            {

                Console.WriteLine("Press 0 to EXIT");
                Console.WriteLine("Press 1 for Add Employyee");
                Console.WriteLine("Press 2 for Remove Employee");
                Console.WriteLine("Press 3 for Find Employee");
                Console.WriteLine("Press 4 for Print All Employee");
                Console.WriteLine("Press 5 to Display companys Salary Expenses");
                Console.WriteLine("Press 6 to Display companys info");
                Console.WriteLine("Enter your choice");
                String choiceValue = Console.ReadLine();
                choice = int.Parse(choiceValue);




                switch (choice)
                {
                    case 0:
                        Console.WriteLine("Thank You");
                        break;
                    case 1:
                        Employee emp = new Employee();
                        emp.AcceptEmployee();
                        comp.AddEmployee(emp);
                        Console.WriteLine("Employee Added");
                        break;
                    case 2:
                        Console.WriteLine("Enter id");
                        int id = Convert.ToInt32(Console.ReadLine());
                        if (comp.RemoveEmployee(id))
                        {
                            Console.WriteLine("Employee Removed");
                        }
                        else
                        {
                            Console.WriteLine("Some error");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Enter id");
                        int find_id = Convert.ToInt32(Console.ReadLine());
                        LinkedListNode<Employee> e = comp.FindEmployee(find_id);
                        if (e != null)
                        {
                            e.Value.PrintEmployee();
                        }
                        break;
                    case 4:
                        Console.WriteLine("All Employees");
                        foreach (Employee empl in comp.EmpList)
                        {
                            empl.PrintEmployee();
                        }
                        break;
                    case 5:
                        Console.WriteLine("Salary Expenses : " + comp.SalaryExpenses);
                        break;
                    case 6:
                        comp.PrintCompany();
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }


            } while (choice != 0);
            Console.WriteLine("Press Any Key to Exit");
            Console.ReadKey();

        }
    }


}



