using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_Implementation
{
    public class MyLinkeList<T>
    {
        T value;
        MyLinkeList<T> next;
        MyLinkeList<T> head;
        public MyLinkeList(T value)
            {
                this.value = value;
            }
        public T getValue() { return this.value; }
        public MyLinkeList<T> getNext() { return next; }

        public void setValue(T value) { this.value = value; }
        public void setNext(MyLinkeList<T> next) { this.next = next; }

        public void add(T value)
        {
            MyLinkeList<T> temp = new MyLinkeList<T>(value);
            temp.value = value;
            temp.next = head;
            head = temp;
            
        }

        public void printValues(MyLinkeList<T> ls)
        {
            while (ls.next!=null)
            {
                Console.WriteLine(ls.value);
                ls.next = ls.next.next;
            }

        }

    }
}
