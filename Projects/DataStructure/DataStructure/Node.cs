using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class Node
    {
        public Node next = null;
        public int data;

        public Node(int d)
        {
            this.data = d;
        }
    }
}
