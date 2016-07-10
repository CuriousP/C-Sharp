using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class Stack
    {
        Node top;

        int Pop()
        {
            if(top != null)
            {
                int item = this.top.data;
                top = top.next;

                return item;
            }

            return -1;
        }

        void Push(int item)
        {
            Node t = new Node(item);
            t.next = top;
            top = t;
        }

        int Peek()
        {
            return top.data;
        }
    }
}
