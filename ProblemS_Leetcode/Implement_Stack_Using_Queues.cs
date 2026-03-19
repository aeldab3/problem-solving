using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ProblemS_Leetcode
{
    internal class Implement_Stack_Using_Queues
    {
        /*
         225- Implement Stack using Queues
         Implement a last-in-first-out (LIFO) stack using only two queues.The implemented stack should support all the functions of a normal stack (push, top, pop, and empty).
        */

        public static void Run()
        {
            MyStack myStack = new MyStack();
            myStack.Push(1);
            myStack.Push(2);
            Console.WriteLine("Top in Stack is " + myStack.Top()); // return 2
            Console.WriteLine("Pop in Stack is " + myStack.Pop()); // return 2
            Console.WriteLine("Are the Stack is Empty " + myStack.Empty()); // return False

        }

        public class MyStack
        {
            Queue<int> q1 = new Queue<int>();
            Queue<int> q2 = new Queue<int>();

            public MyStack()
            {

            }

            public void Push(int x)
            {
                q2.Enqueue(x);
                while (q1.Count > 0)
                {
                    q2.Enqueue(q1.Dequeue());
                }
                var temp = q1;
                q1 = q2;
                q2 = temp;
            }

            public int Pop()
            {
                if (Empty())
                {
                    Console.WriteLine("It's Empty");
                    return 0;
                }
                return q1.Dequeue();
            }

            public int Top()
            {
                return q1.Peek();
            }

            public bool Empty()
            {
                return q1.Count == 0;
            }
        }
    }
}
