using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ProblemS_Leetcode.Merge_Two_Sorted_Lists;

namespace ProblemS_Leetcode
{
    /*
        19- Remove Nth Node From End of List
        Given the head of a linked list, remove the nth node from the end of the list and return its head.
    */

    internal class Remove_Nth_Node_From_End_of_List
    {
        public static void Run()
        {
            ListNode l1 = new ListNode(2, new ListNode(4, new ListNode(3, new ListNode(5))));
            Solution s = new Solution();
            ListNode removedFromEnd = s.RemoveNthFromEnd(l1, 2);
            printList(removedFromEnd);
        }

        public class Solution
        {
            public ListNode RemoveNthFromEnd(ListNode head, int n)
            {
                ListNode dummy = new ListNode();
                dummy.next = head;
                ListNode fast = dummy;
                ListNode slow = dummy;
                for (int i = 0; i <= n; i++)
                {
                    fast = fast.next;
                }
                while (fast != null)
                {
                    fast = fast.next;
                    slow = slow.next;
                }
                slow.next = slow.next.next;
                return dummy.next;
            }
        }
    }
}
