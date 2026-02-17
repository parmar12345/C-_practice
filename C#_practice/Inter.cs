using System;
using System.Collections.Generic;
using System.Text;

namespace C__practice
{
    internal interface Inter
    {
        public interface test
        {
            void sum(int a, int b);
            void diff(int a, int b);

            void umang();
        }

        public interface test1
        {
            void mul(int a, int b);
            void divi(int a, int b);

            void umang();
        }

        public class test2
        {
           public void run()
            {
                Console.WriteLine("imang");
            }
        }


        public class class1 : test2,test, test1
        {
            public void diff(int a, int b)
            {
                Console.WriteLine((a + b));
            }

            public void divi(int a, int b)
            {
                Console.WriteLine((a / b));
            }

             void test.umang()
            {
                Console.WriteLine("umang");
            }

            void test1.umang()
            {
                Console.WriteLine("umang");
            }

            public void mul(int a, int b)
            {
                Console.WriteLine((a * b));
            }

            public void sum(int a, int b)
            {
                Console.WriteLine(  (a - b));   
            }

            public void krick()
            {
                Console.WriteLine("umang");
            }
        }
    }
}
