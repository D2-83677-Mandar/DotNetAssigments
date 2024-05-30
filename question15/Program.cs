using SharedLib;
using System;
using System.Collections.Generic;


namespace question15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Company company = new Company();
            company.Accept();

            int choice;
            do
            {
                Console.WriteLine("1 : adding employee to company \n 2 : removing employee \n 3 : find employee by id \n  4 : display company info and display all employees \n 0 : Exit");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Employee emp = CreateEmployee();
                        company.AddEmployee(emp);
                        Console.WriteLine("Employee add successfully!.....");
                        break;
                    case 2:
                        Console.WriteLine("Enter Id : ");
                        bool result = company.RemoveEmployee(Convert.ToInt32(Console.ReadLine()));
                        Console.WriteLine(result == true ? "Employee removed!....." : "Employee Not Removed!....");
                        break;
                    case 3:
                        Console.WriteLine("Enter Id : ");
                        LinkedListNode<Employee> empNode = company.FindEmployee(Convert.ToInt32(Console.ReadLine()));
                        Employee emp1 = empNode.Value;
                        Console.WriteLine(emp1 != null ? "Employee Found!.....\n" + emp1.ToString() : "Employee Not Found!....");
                        break;
                    case 4:
                        Console.WriteLine(company);
                        foreach (Employee e in company.EmpList)
                        {
                            Console.WriteLine(e);
                        }
                        break;
                    case 0:
                        Console.WriteLine("Thank you!......");
                        break;
                    default:
                        Console.WriteLine("Enter valid choice!.....");
                        break;
                }

            } while (choice != 0);
        }

        static Employee CreateEmployee()
        {
            Console.WriteLine("\nSelect Employee Type:");
            Console.WriteLine("1. Employee");
            Console.WriteLine("2. Manager");
            Console.WriteLine("3. Supervisor");
            Console.WriteLine("4. Wage Employee");
            Console.Write("Enter your choice: ");
            int empType = int.Parse(Console.ReadLine());

            Employee employee = null;

            switch (empType)
            {
                case 1:
                    employee = new Employee();
                    break;
                case 2:
                    employee = new Manager();
                    break;
                case 3:
                    employee = new Supervisor();
                    break;
                case 4:
                    employee = new WageEmp();
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    return null;
            }

            employee.Accept();
            Console.WriteLine("Employee added successfully.");
            return employee;
        }
    }
}
