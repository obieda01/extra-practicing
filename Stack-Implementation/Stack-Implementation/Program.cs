using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Implementation
{
    class Program
    {
        static void Main(string[] args)
        {

            MyStack<string> st = new MyStack<string>();

            st.push("Ahmad1");
            st.push("Ahmad2");
            st.push("Ahmad3");

            st.printAll();

        }
    }
}
