using System;
using System.Collections.Generic;
using System.Text;

namespace C__practice
{
    internal class Encapsulation
    {
        private int Age;  //data hidnig

         public void SetAge(int age)
        {
            this.Age = age;
        }

        public int GetAge()
        {
            return Age;
        }
    }
}
