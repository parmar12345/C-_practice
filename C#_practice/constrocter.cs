using System;
using System.Collections.Generic;
using System.Text;

namespace C__practice
{
    internal class constrocter
    {
        int age;
        string name;

        //Default Constructor
        public constrocter()
        {
            age = 23;
            name = "umang";
            //Console.WriteLine(name);
        }

        // parameter constrocter

        public constrocter(int a, string b)
        {
            age = a;
            name = b;
            Console.WriteLine(name);
        }

        // copy constroter 
        public constrocter(constrocter obj)
        {
            age = obj.age;
            name = obj.name;
            //Console.WriteLine(name);
        }

    }
}
