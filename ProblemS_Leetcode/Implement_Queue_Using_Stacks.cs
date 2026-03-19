using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemS_Leetcode
{
    internal class Implement_Queue_Using_Stacks
    {
        /*
         232- Implement Queue using Stacks
         Implement a first in first out (FIFO) queue using only two stacks. The implemented queue should support all the functions of a normal queue (push, peek, pop, and empty).
         */
        public static void Run()
        {
            MyQueue myQueue = new MyQueue();
            myQueue.Push(1); // queue is: [1]
            myQueue.Push(2); // queue is: [1, 2] (leftmost is front of the queue)
            Console.WriteLine("This is the Peek => " + myQueue.Peek()); // return 1
            Console.WriteLine("Remove This Element => " + myQueue.Pop()); // return 1, queue is [2]
            Console.WriteLine("Are is Empty => " + myQueue.Empty()); // return false
        }

        public class MyQueue
        {
            Stack<int> inStack = new Stack<int>();
            Stack<int> outStack = new Stack<int>();

            public MyQueue()
            {
            }

            public void Push(int x)
            {
                inStack.Push(x);
            }

            private void Move()
            {
                if (outStack.Count == 0)
                {
                    while (inStack.Count > 0)
                    {
                        outStack.Push(inStack.Pop());
                    }
                }
            }

            public int Pop()
            {
                Move();
                return outStack.Pop();
            }

            public int Peek()
            {
                Move();
                return outStack.Peek();
            }

            public bool Empty()
            {
                return inStack.Count == 0 && outStack.Count == 0;
            }
        }
    }
}