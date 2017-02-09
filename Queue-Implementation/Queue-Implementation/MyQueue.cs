using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_Implementation
{
    public partial  class MyQueue<T>
    {
         public class QueueNode<T>
        {
            public T value;
            public QueueNode<T> next;
            public QueueNode(T value) { this.value = value; }
        }
        QueueNode<T> last;
        QueueNode<T> first;


        public MyQueue() { }
        //public MyQueue(T value) { this.value = value; }
        public void enqueue(T value)
        {
            QueueNode<T> temp = new QueueNode<T>(value);
            if (last!=null)
            {
                last.next = temp;
            }
            last = temp;
            
        }

        public void printAll()
        {
            MyQueue<T> temp = head;
            while (temp!=null)
            {
                Console.WriteLine(temp.value);
                temp = temp.next;
            }
        }

    }
}
