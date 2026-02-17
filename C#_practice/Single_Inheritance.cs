using System;
using System.Collections.Generic;
using System.Text;

namespace C__practice
{
    internal class Single_Inheritance
    {
        class Parent
        {
            public void ParentMethod()
            {
                Console.WriteLine("Parent Method");
            }
        }

        class Child : Parent
        {
            public void ChildMethod()
            {
                Console.WriteLine("Child Method");
            }
        }

    }
}
