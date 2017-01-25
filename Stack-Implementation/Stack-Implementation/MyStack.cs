using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Implementation
{
    public class MyStack<T>
    {
        public class MyStackNode<T>
        {
             public T value;
            public MyStackNode<T> next;
            public MyStackNode(T value) {this.value=value;}
        }

        MyStackNode<T> head;

        public void push(T value)
        {
            MyStackNode<T> temp = new MyStackNode<T>(value);
            if (head != null)
            {
                temp.next = head;
            }
            head = temp;
        }

        public T pop()
        {
            if (head != null)
            {
                T val = head.value;
                head = head.next;
                return val;
            }
            else throw new FieldAccessException();
        }


        public void printAll()
        {
            MyStackNode<T> temp = head;
            while (temp!=null)
            {
                Console.WriteLine(temp.value);
                temp = temp.next;

            }
        }
    }
}
   

