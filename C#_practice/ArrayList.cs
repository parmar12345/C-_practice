using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace C__practice
{
    internal class ArrayList
    {
       public void arratlistmethod()
        {
            // Create ArrayList
          ArrayList list = new ArrayList();

            // Add elements (different types)
            list.Add(10);           // int
            list.Add("Hello");      // string
            list.Add(3.14);         // double
            list.Add(true);         // bool
            list.Add('A');          // char
        }
    }
}
