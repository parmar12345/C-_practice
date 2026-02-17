using System;
using System.Collections.Generic;
using System.Text;

namespace C__practice
{
    internal class Constrocter_Example
    {
        public int varint;
        public string varString;
        public Constrocter_Example()
        {
            varint = 100;
            varString = "umang";
        }


        public Constrocter_Example(int varint, string varString)
        {
            this.varint = varint;
            this.varString = varString;
        }
    }
}
