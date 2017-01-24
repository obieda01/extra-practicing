using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_Implementation
{
    class Program
    {
        static void Main(string[] args)
        {

            MyQueue<string> queue = new MyQueue<string>();

            queue.enqueue("Ahmad1");
            queue.enqueue("Ahmad2");
            queue.enqueue("Ahmad3");
            queue.printAll();

        }
    }
}
