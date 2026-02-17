using System;
using System.Collections.Generic;
using System.Text;

namespace C__practice
{
    public class Inheritance
    {
        public class Parent
        {
            public Parent() 
            {
                Console.WriteLine("I am Parent class constructor");
            }

            static Parent()
            {                           
                Console.WriteLine("I am Parent class static constructor");
            }

            public  void ParentMethod()
            {
                Console.WriteLine("I am Parent Method");
            }


            //public virtual void ParentMethod()
            //    {
            //    Console.WriteLine("I am Parent Method");
            //}

            public void Example_method_hiding()
            {
                Console.WriteLine("this is a method hiding in parent class");
            }
        }

        public class Child : Parent
        {           
            public Child()
            {
                Console.WriteLine("I am child class constructor");
            }
             
            static Child()
            {
                Console.WriteLine("I am child class static constructor");
            }   
            public void ChildMethod()
            {
                Console.WriteLine("I am Child Method");
            }
            //public sealed override void ParentMethod()
            // {
            //    Console.WriteLine("I am updated Parent Method");
            //}

            //public new void Example_method_hiding()
            //{
            //    Console.WriteLine("this is a method hiding in parent class in child class");
            //}
        }
    }
}
