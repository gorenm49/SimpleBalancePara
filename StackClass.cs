using System;

namespace SimpleBalancePara
{
    public class StackClass
    {
        public Node top;

        public StackClass()
        {
            this.top = null;
        }

        public void Push(int data)
        {
            Node node = new Node(data);
            if (this.top == null)
            {
                node.next = null;
            }
            else
            {
                node.next = this.top;
            }
            this.top = node;
        }

        public void Display()
        {
            Node temp = this.top;
            while (temp != null)
            {
                System.Console.WriteLine(temp.data+ " ");
                temp = temp.next;
            }  
        }

        public void Peek()  
        {
            if (this.top == null)
            {
                System.Console.WriteLine("stack is empty");
                return;
            }
        }

        public void Pop()    
        {
            if (this.top == null)
            {
                System.Console.WriteLine("Stack is empty");
                return;
            }
            this.top = this.top.next;
        }

        public int IsEmpty()
        {
            while (this.top != null)
            {
                Peek();
                Pop();
            }
            return 0;
        }
        
    }
}