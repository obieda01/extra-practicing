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
        MyLinkeList<T> top;
        public MyLinkeList() { }
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
            temp.next = top ;
            top = temp;
            
        }
        public T remove()
        {
            
            T value = top.value;
            top = top.next;
            return value;
        }

        public void printValues()
        {
            MyLinkeList<T> temp = top;
            while (temp!=null)
            {
                Console.WriteLine(temp.value);
                temp = temp.next;
            }

        }

    }
}
