using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Restaurant
{
    public class node
    {
         string Data;
         node Next;
        public node(string Data)
        {
            this.Data = Data;
        }
        public string data { get { return Data; } set { Data = value; } }
        public node next { get { return Next; } set { Next = value; } }
    }
}
