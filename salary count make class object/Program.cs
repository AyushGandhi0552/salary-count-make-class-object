using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salary_count_make_class_object
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee ayu = new Employee();

            ayu.input();
            ayu.output();
            Console.ReadKey();
        }
    }
}
