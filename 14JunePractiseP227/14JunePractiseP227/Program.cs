using _14JunePractiseP227.Classes;
using System;

namespace _14JunePractiseP227
{
    class Program
    {
        static void Main(string[] args)
        {

            string input;

            Company CodeAz = new Company()
            {
                EmployeeLimit = 5,
            };
            do
            {
                Console.WriteLine("1. Iscileri elave et!");
                Console.WriteLine("2. Isciler uzerinde axtarıs et!");
                Console.WriteLine("0. Menudan cıx");

                input = Console.ReadLine();

             

                switch (input)
                {
                    case "1":
                        //Add Employee
                        CodeAz.AddEmployee(CreateEmployee());
                        break;
                    case "2":
                        Console.Write("Axtarmaq istediyiniz iscinin fullname-ini daxil edin: ");
                        string searchEmp = Console.ReadLine();
                        Employee[] newArr = CodeAz.SearchEmployees(searchEmp);
                        foreach (var item in newArr)
                        {
                            Console.WriteLine($"{item.Name} {item.Surname}, {item.Position}");
                        }
                        //Search Employees
                        break;
                    default:
                        break;
                }

            } while (input!="0");

            
        }

        public static Employee CreateEmployee()
        {
            Console.Write("Iscinin adini daxil edin: ");
            string empName = Console.ReadLine();

            Console.Write("Iscinin Soyadini daxil edin: ");
            string empSurname = Console.ReadLine();

            Console.Write("Iscinin Positon-unu daxil edin: ");
            string empPosition = Console.ReadLine();
            string empAgeStr;
            byte empAge;
            do
            {
                Console.Write("Iscinin Yasini daxil edin: ");
                 empAgeStr = Console.ReadLine();
                
            } while (!byte.TryParse(empAgeStr, out empAge));

            Employee employee = new Employee(empName, empPosition)
            {
                Name = empName,
                Position = empPosition,
                Age = empAge,
                Surname = empSurname
            };

            return employee;
        }
    }
}
