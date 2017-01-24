using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_Implementation
{
    class Program
    {
        static void Main(string[] args)
        {
            MyLinkeList<string> ls = new MyLinkeList<string>("ahmad1");
            ls.add("ahmad2");
            ls.add("ahmad3");

            ls.add("ahmad4");
            ls.printValues(ls);

        }
    }
}
