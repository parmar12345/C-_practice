using System;
using System.Collections.Generic;
using System.Text;

namespace C__practice
{
    public class Copy_Constroctor
    {
        public int varint;
        public string varString;
        public Copy_Constroctor(int varint, string varString)
        {
            this.varint = varint;
            this.varString = varString;
        }


        public Copy_Constroctor(Copy_Constroctor cp)
        {
            this.varint = cp.varint;
            this.varString = cp.varString;
        }





        //Copy_Constroctor cp = new Copy_Constroctor(100, "umang");
        //Console.WriteLine(cp.varString + " = " + cp.varint);

        //Copy_Constroctor cp2 = new Copy_Constroctor(cp);
        //Console.WriteLine(cp.varString + " = " + cp.varint);
    }
}
