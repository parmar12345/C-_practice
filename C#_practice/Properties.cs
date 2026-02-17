using System;
using System.Collections.Generic;
using System.Text;

namespace C__practice
{
    internal class Properties
    {
        //Automated property
        public int size {  get; set; }

        // read only property
        public int ReadOnlyProperty { get; private set; }
        public void ReadOnlyPro()
        {
            ReadOnlyProperty = 345;
        }



        // write only property
        public int WriteOnlyProperty {private get; set; }

        public void WriteOnlypro()
        { 
            Console.WriteLine(WriteOnlyProperty);
        }


        //Properties pro = new Properties();

        //pro.size = 10; // set
        //Console.WriteLine(pro.size); // get


        //pro.ReadOnlyPro(); // set the value
        //Console.WriteLine(pro.ReadOnlyProperty); // get value
    

        //pro.WriteOnlyProperty = 24;
        //pro.WriteOnlypro();

    
    }
}
