using System;
using System.Collections.Generic;
using System.Text;

namespace C__practice
{
    internal class GenericCollection
    {
        public void listExample()
        {
            List<string> list = new List<string>();

            // add value 
            list.Add("umang");
            list.Add("monil");
            list.Add("kartik");
            list.Add("kalpesh");

            // read the value
            string val = list[0];
            string val1 = list[1];
            string val2 = list[2];
            string val3 = list[3];

            // update
            list[0] = "vivek";



             foreach (string item in list)
            {
                Console.WriteLine(item);
            }


            // delete
            list.Remove("umang");
            list.RemoveAt(1);
            list.Clear();


            // coutn  
            int coutn = list.Count;

            // contains
            bool isvalueexist = list.Contains("umang");

        }

        public void dictionaryExample()
        {
            Dictionary<int,string> dict = new Dictionary<int,string>();
        }


        public void listEmployExample()
        {
            Employee employee = new Employee();
            employee.Id = 1;
            employee.Name = "umanh";
            employee.salary = 11000;

            Employee employee1 = new Employee();
            employee1.Id = 2;
            employee1.Name = "monil";
            employee1.salary = 12000;


            Employee employee2 = new Employee();
            employee2.Id = 3;
            employee2.Name = "kartik";
            employee2.salary = 13000;


            List<Employee> list = new List<Employee>();

            list.Add(employee);
            list.Add(employee2);
            list.Add(employee2);


            list.Add(new Employee() { Id = 104,Name = "vivek",salary=20000});

            foreach (Employee emp in list) 
            { 
                Console.WriteLine(emp.Id);
                Console.WriteLine(emp.Name);
                Console.WriteLine(emp.salary);
            }
        }
    }
}
