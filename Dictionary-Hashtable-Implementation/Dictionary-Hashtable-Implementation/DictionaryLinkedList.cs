using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary_Hashtable_Implementation
{
    class DictionaryLinkedList<T>
    {
        T value;
        T key;
        int hashCode;
        DictionaryLinkedList<T> next;

        DictionaryLinkedList(T value,T key,int hashCode,DictionaryLinkedList<T> next)
        {
            this.value = value;
            this.key = key;
            this.hashCode = hashCode;
            this.next = next;
        }
    }
}
