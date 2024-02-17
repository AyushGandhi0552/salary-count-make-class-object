using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salary_count_make_class_object
{
    public class Employee
    {
        int id = 0;
        string name = "";
        int salary = 0;

        public void input()
        {
            Console.WriteLine("Please Enter ID:");
            id=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please Enter Name:");
            name=Console.ReadLine();

            Console.WriteLine("Please Enter Salary:");
            salary=Convert.ToInt32(Console.ReadLine());
        }
        public void output() 
        {
            Console.WriteLine(id);
            Console.WriteLine(name);
            Console.WriteLine("The salary is:"+salary);

            int hra = Convert.ToInt32(salary * 0.5);
            Console.WriteLine("The hra is:" + hra);

            int da=Convert.ToInt32(salary * 0.2);
            Console.WriteLine("The DA is:" + da);

            int totalsalary = salary + hra + da;
            Console.WriteLine("The Totalsalary is:" + totalsalary);

            int tax=Convert.ToInt32(totalsalary * 0.1);
            Console.WriteLine("The tax is:"+tax);

            int netsalary=Convert.ToInt32(totalsalary -tax);
            Console.WriteLine("The netsalary is:"+netsalary);

        }
    }
}
