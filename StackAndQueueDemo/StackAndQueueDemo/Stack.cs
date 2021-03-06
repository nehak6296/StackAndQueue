using System;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueueDemo
{
    class Stack
    {
        private Node top;
        public Stack()
        {
            this.top = null;
        }
        internal void Push(int value)
        {
            Node node = new Node(value);
            if (this.top == null)
                node.next = this.top;
            else
                node.next = this.top;
            this.top = node;
            Console.WriteLine("{0} pushed to stack", value);

        }
        public void Display()
        {
            Node temp = this.top;
            while (temp != null)
            {
                Console.WriteLine(temp.data + "  ");
                temp = temp.next;
            }
        }
    }
}
