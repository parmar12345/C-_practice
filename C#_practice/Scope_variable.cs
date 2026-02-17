using System;
using System.Collections.Generic;
using System.Text;

namespace C__practice
{
    internal class Scope_variable
    {

        //static variable Share by all the object
        public static string CollegeName = "GTU";

        // 🔹 Instance variables (separate for each object)
        string name;
        int marks;

        // Instance method
        public void Accept(string n, int m)
        {
            // local variable
            int passMarks = 35;

            name = n;
            marks = m;

            if (marks >= passMarks)
            {
                Console.WriteLine(name + "passed");
            }
            else
            {
                Console.WriteLine(name + "failed");
            }
        }


        // instance method
        public void display()
        {
            Console.WriteLine(
               "Name: " + name +
               ", Marks: " + marks +
               ", College: " + CollegeName

           );
        }

        // Static variable access (no object needed)
        // Console.WriteLine(Scope_variable.CollegeName);

        //    Scope_variable p = new Scope_variable();
        //    p.Accept("umang", 45);
        //    p.display();
    }
}
