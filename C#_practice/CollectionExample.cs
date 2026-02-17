using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace C__practice
{
    public class CollectionExample
    {
    
            public void ArraylistCollection()
        {
            ArrayList list = new ArrayList();
            list.Add(10);        // int (boxed)
            list.Add("Hello");   // string
            list.Add(DateTime.Now);       // double

            int x = (int)list[0]; // Unboxing required
            string y = Convert.ToString(list[1]);
            DateTime z = (DateTime)list[2];

            // update
            list[1] = "umang";


            // insert 
            list.Insert(1, "monil"); // 10,monil,hello,detatime now

            // remove   

            list.Remove("hello");

            // reomve at 
            list.RemoveAt(1);


            // count
            int count = list.Count;

            if (list.Contains(10))
            {
                Console.WriteLine("valur exist");
            }
            else
            {
                Console.WriteLine("vlaue does not exist");
            }

            // remove all
            //list.Clear();
        }

            public void HashtableCollection()
        {
            Hashtable ht = new Hashtable();
            ht.Add(1, "Umang");
            ht.Add("age", 22);
            ht.Add(3, true);


            string age = (string)ht[1];
            int age1 = (int)ht["age"];
            bool bl = (bool)ht["3"];

            // update 
            ht["age"] = 23;


            //contains
            bool contains = ht.Contains(1);
            // ==
            bool contains1 = ht.ContainsKey(1);
            bool contains2 = ht.ContainsValue(2);


            foreach (object key in ht.Keys)
            {
                Console.WriteLine(key);
            }


            foreach (object o in ht.Values)
            {
                Console.WriteLine(o);
            }

        }

            public void StackCollection()
           {
            // stack

            Stack st = new Stack();
            st.Push(1);
            st.Push("test");
            st.Push(DateTime.Now);
            st.Push(true);

            // peek 
            int valuePeek = Convert.ToInt32(st.Pop()); // return but do not delete it

            // to get the vlaue  | pop

            int value = Convert.ToInt32(st.Pop()); // return and delete it
            string value1 = Convert.ToString(st.Pop()); // return and delete it
            DateTime value2 = Convert.ToDateTime(st.Pop()); // return and delete it
            bool value3 = Convert.ToBoolean(st.Pop()); // return and delete it

            //  count 

            int Count = st.Count; // 


            // cleare
        }

           public void QueueCollection()
           {
            // queue 


            Queue queue = new Queue();

            // Insert 

            queue.Enqueue(21);
            queue.Enqueue("umang");
            queue.Enqueue(DateTime.Now);
            queue.Enqueue(true);

            // peek of queue

            int dqvaluepeek = Convert.ToInt32(queue.Peek());


            // Delete

            int dqvalue = Convert.ToInt32(queue.Dequeue());
            string dqvalue1 = Convert.ToString(queue.Dequeue());
            DateTime dqvalue2 = Convert.ToDateTime(queue.Dequeue());
            bool dqvalue3 = Convert.ToBoolean(queue.Dequeue());
           }

        }
    }

