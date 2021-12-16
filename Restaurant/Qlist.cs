using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Restaurant
{
    public class Qlist
    {



         node First, Last, Mynode;
        public Qlist()
        {
            first = last = null;
        }

        #region  properties

        public node first { get { return First; } set { First = value; } }
        public node last { get { return Last; } set { Last = value; } }
        public node mynode { get { return Mynode; } set { Mynode = value; } }

        #endregion

        public void enqueue(string data)
        {
            //add order
            mynode = new node(data);
            if (first == null)
                first = last = mynode;
            else
            {
                last.next = mynode;
                last = mynode;
            }
        }
        public string dequeue()
        {
            //get first order
            if (first == null)
                return " ";
            else
            {
                string v = first.data;
                first = first.next;
                return v;
            }
        }
       
        public string print()
        {
            //get all orders
            node p = first;
            string x;
            if (first == null)
            {
                return " ";
            }
            else
            {
                x = " ";
                while (p != null)
                {
                    x += p.data;
                    p = p.next;
                }
                return x;
            }

        }
        public void clear()
        {
            // new order
            first = last = null;


        }

    }
}
