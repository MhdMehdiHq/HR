using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR
{
    internal static class Lists
    {
        public static List<Employee> employees = new List<Employee>();
    }
    internal class HireRemove
    {
        //متد زیر برای افزودن کارمند میباشد 
        public static void HireEmployee()
        {
            Employee employee = new Employee();
            Console.Write("Enter employee id: ");
            employee.EmployeeId = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Enter employee firstname: ");
            employee.EmployeeFirstName = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Enter employee lastName: ");
            employee.EmployeeLastName = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Enter Salary for this employee: ");
            employee.EmployeeSalary = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Time that employee hired : ");
            Console.WriteLine(employee.EmployeeDate = DateTime.Now);
            Lists.employees.Add(employee);
            Console.WriteLine("Employee added successfully!");
            Thread.Sleep(2000);
            Console.Clear();
        }


        //متد زیر برای اخراج کارمند از طریق آیدی میباشد میباشد 
        public static void FireEmployee()
        {
            Console.Write("Enter employee id which you want to fire: ");
            int RemoveId = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Employee employee = Lists.employees.Find(x => x.EmployeeId == RemoveId);
            if (employee != null)
            {
                Lists.employees.Remove(employee);
                Console.WriteLine("Employee fired !");
                Thread.Sleep(2000);
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Employee not found!");
                Thread.Sleep(2000);
                Console.Clear();
            }
        }


        //این متد برای آپدیت کردن اطلاعات کارمند ما میباشد 
        //اعم از نام و فامیلی کارمند،شماره آیدی آن شخص و حقوق دریافتی 
        public static void UpdateEmployee()
        {
            Console.Write("Enter Employee Id to update information: ");
            int updateId = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Employee employee = Lists.employees.Find(x => x.EmployeeId == updateId);
            if (employee != null)
            {
                Console.Write("Enter employee new firstname: ");
                employee.EmployeeFirstName = Console.ReadLine();
                Console.WriteLine();

                Console.Write("Enter employee new lastname: ");
                employee.EmployeeLastName = Console.ReadLine();
                Console.WriteLine();

                Console.Write("Enter employee new salary: ");
                employee.EmployeeSalary = double.Parse(Console.ReadLine());

                Console.WriteLine("Employee information updated successfully!");
                Thread.Sleep(2000);
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Employee not found!");
                Thread.Sleep(2000);
                Console.Clear();
            }

        }


        //این متد برای چاپ اطلاعات کارمند کاربرد دارد
        //نکته
        //برای استفاده از این متد شما ابتدا باید یک یا چند کارمند تعریف کرده و بعد میتوانید ازین متد استفاده کنید
        //در غیر این صورت،این متد برای شما کاری انجام نخواهد داد
        public static void ShowEmployeeInfo()
        {
            Console.Write("Enter Employee Id to show details: ");
            int showId = int.Parse(Console.ReadLine());

            Employee employee = Lists.employees.Find(x => x.EmployeeId == showId);
            if (employee != null)
            {
                Console.WriteLine("Employee id: " + employee.EmployeeId);
                Console.WriteLine("Employee firstname: " + employee.EmployeeFirstName);
                Console.WriteLine("Employee lastname: " + employee.EmployeeLastName);
                Console.WriteLine("Employee salary: " + employee.EmployeeSalary);
                Console.WriteLine(employee.EmployeeDate);
                Thread.Sleep(2000);
            }
            else
            {
                Console.WriteLine("Employee not found!");
                Thread.Sleep(2000);
                Console.Clear();
            }
        }



    }
}
