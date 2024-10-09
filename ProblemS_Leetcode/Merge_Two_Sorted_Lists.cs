using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemS_Leetcode
{
    internal class Merge_Two_Sorted_Lists
    {

        //Merge the two lists into one sorted list. The list should be made by splicing together the nodes of the first two lists.

        public static void Run()
        {
            ListNode l1 = new ListNode(0, new ListNode(1, new ListNode(18)));
            ListNode l2 = new ListNode(19, new ListNode(99));

            Solution merge = new Solution();
            ListNode mergeList = merge.MergeTwoLists(l1, l2);
            printList(mergeList);
        }

        public static void printList(ListNode head)
        {
            while (head != null)
            {
                Console.WriteLine(head.val);

                if (head.next != null)
                {
                    Console.WriteLine(" -> ");
                }

                head = head.next;
            }

        }


        public class ListNode
        {
            
             public int val;
             public ListNode next;
             public ListNode(int val = 0, ListNode next = null)
             {
                this.val = val;
                this.next = next;
             }
        }
 
        public class Solution
        {
            public ListNode MergeTwoLists(ListNode list1, ListNode list2)
            {
                //Create a dummy node as the starting point of the merged list
                ListNode dummy = new ListNode();
                //Pointer to track the current node in the merged list
                ListNode current = dummy;

                while(list1 != null && list2 != null) {

                    if (list1.val <= list2.val) {
                        current.next = list1;
                        list1 = list1.next;
                    }
                    else
                    {
                        current.next = list2;
                        list2 = list2.next;
                    }

                    // Move the current pointer to the next node
                    current = current.next;
                
                }

                if (list1 != null)
                {
                    current.next = list1;
                }
                else if (list2 != null)
                {
                    current.next = list2;
                }

                //Return the merged list
                return dummy.next;
            }
        }
    }
}
