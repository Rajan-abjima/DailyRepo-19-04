using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQSample
{
    class Product
    {   
       static void Main(string[] args)
       {    //Linq Querey

            //int[] age = { 12, 34, 56, 76, 45, 78, 90, 23, 19, 12, 56, 24, 33 };
            //var a = from i in age where i > 20 orderby  i descending select i;

            string[] Names = { "Kavita", "Soniya", "Divya", "Kavya", "Sunita" };
            //var a = from name in Names where name.Contains("K") select name;

            var a = from name in Names where name.StartsWith("S") select name;

            foreach(string item in a)
            {
                Console.WriteLine(item);
            }
            //Console.ReadLine();

            //Methods
            var a1 = Names.Where(x => x.Contains("K"));
            foreach (string items in a1)
            {
                Console.WriteLine(items);
            }


            List<Employee1> emp1 = new List<Employee1>() {

            new Employee1() {emp_id = 300, emp_name = "Anu",
                                           emp_lang = "C#"},

            new Employee1() {emp_id = 301, emp_name = "Mohit",
                                              emp_lang = "C"},

            new Employee1() {emp_id = 302, emp_name = "Sona",
                                          emp_lang = "Java"},

            new Employee1() {emp_id = 303, emp_name = "Lana",
                                          emp_lang = "Java"},

            new Employee1() {emp_id = 304, emp_name = "Lion",
                                            emp_lang = "C#"},

            new Employee1() {emp_id = 305, emp_name = "Ramona",
                                            emp_lang = "Java"},

            };

            List<Employee2> emp2 = new List<Employee2>() {

            new Employee2() {emp_id = 300, emp_dept = "Designing",
                                              emp_salary = 23000},

            new Employee2() {emp_id = 301, emp_dept = "Developing",
                                               emp_salary = 40000},

            new Employee2() {emp_id = 302, emp_dept = "HR",
                                       emp_salary = 50000},

            new Employee2() {emp_id = 303, emp_dept = "Designing",
                                              emp_salary = 60000},

            };

            // Query to find the name and
            // the department of the employees
            // Using Join Method
            var res = emp1.Join(emp2,
                                e1 => e1.emp_id,
                                e2 => e2.emp_id,
                                (e1, e2) => new
                                {
                                    EmployeeName = e1.emp_name,
                                    EmployeeDepartment = e2.emp_dept
                                });

            // Display result
            Console.WriteLine("Employee Name and their Department:");
            foreach (var val in res)
            {
                Console.WriteLine("Employee Name: {0} Department: {1}",
                             val.EmployeeName, val.EmployeeDepartment);
            }
            Console.WriteLine("_________________________");
            // Using Inner Join
            var res1 = from e1 in emp1
                       join e2 in emp2 on e1.emp_id equals e2.emp_id
                       select new
                       {
                           Emp_Name = e1.emp_name,
                           Emp_Salary = e2.emp_salary
                       };

            // Display result
            Console.WriteLine("Employee and their Salary: ");
            foreach (var val in res1)
            {
                Console.WriteLine("Employee Name: {0} Salary: {1}",
                                     val.Emp_Name, val.Emp_Salary);
            }

            // clause in Query Syntax
            var res3 = from e in emp1 where e.emp_id <= 303 select e.emp_name;

            foreach (var val in res3)
            {
                Console.WriteLine("Employee Name: {0}", val);
            }
            // Using Where method
            var res4 = emp2.Where(a => a.emp_salary > 40000);

            foreach (var val in res4)
            {
                Console.WriteLine("Employee ID: {0} ", val.emp_id);
            }

            // Data Source
            ArrayList myarray = new ArrayList();
            myarray.Add("Hii This is Kavita");
            myarray.Add(23);
            myarray.Add(new Employee1() { emp_id = 209, emp_name = "Anjita",emp_lang="C#" });
            myarray.Add(new Employee1() { emp_id = 210, emp_name = "Soniya",emp_lang="Python" });
            myarray.Add(new Employee1() { emp_id = 300, emp_name = "Rohan",emp_lang="C++" });

            // Using OfType operator
            var res5 = from e1 in myarray.OfType<string>()
                       select e1;

            foreach (var val1 in res5)
            {
                Console.WriteLine(val1);
            }

            var res6 = from e2 in myarray.OfType<Employee1>()
                       select e2;

            foreach (var val2 in res6)
            {
                Console.WriteLine(val2.emp_name);
            }
        }
    }
    
}

