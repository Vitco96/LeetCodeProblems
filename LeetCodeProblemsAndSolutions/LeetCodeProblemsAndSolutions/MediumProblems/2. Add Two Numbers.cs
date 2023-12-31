﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

//   You are given two non-empty linked lists representing two non-negative integers.The digits are stored in reverse order, and each of their nodes contains a single digit.Add the two numbers and return the sum as a linked list.
//   You may assume the two numbers do not contain any leading zero, except the number 0 itself.
//   Example 1:


//Input: l1 = [2, 4, 3], l2 = [5, 6, 4]
//Output: [7,0,8]
//Explanation: 342 + 465 = 807.
//Example 2:

//Input: l1 = [0], l2 = [0]
//Output: [0]
//Example 3:

//Input: l1 = [9, 9, 9, 9, 9, 9, 9], l2 = [9, 9, 9, 9]
//Output: [8,9,9,9,0,0,0,1]


//Constraints:

//The number of nodes in each linked list is in the range [1, 100].
//0 <= Node.val <= 9
//It is guaranteed that the list represents a number that does not have leading zeros.



namespace LeetCodeProblemsAndSolutions.MediumProblems
{
    public static class AddTwoNumbersProblem
    {

        //First solution is to use the LinkedList feature of .NET and create two int numbers from the linked list, add them 
        //and after we find out the result, we create a new linked list 
        public static LinkedList<int> AddTwoNumbers(LinkedList<int> l1, LinkedList<int> l2)
        {
            LinkedList<int> resultList = new LinkedList<int>();
            int index1 = 1, index2 = 1;
            int num1 = 0, num2 = 0;

            while (l1.Count != 0)
            {
                num1 += l1.First() * index1;
                index1 *= 10;
                l1.RemoveFirst();
            }

            while (l2.Count != 0)
            {
                num2 += l2.First() * index2;
                index2 *= 10;
                l2.RemoveFirst();
            }

            var result = num1 + num2;

            while (result > 0)
            {
                resultList.AddLast(result % 10);
                result = result / 10;
            }

            return resultList;
        }

        
        //THe second solution is a similar solution but instead of using .Net linked list, we use the example ListNode provided
        public static ListNode AddTwoNumbersWithSpecificClass(ListNode l1, ListNode l2)
        {
            ListNode result = new ListNode();
            ListNode head = result;
            int sum = 0;
            while (l1 != null || l2 != null || sum > 0)
            {
                if (l1 != null)
                {
                    sum += l1.val;
                    l1 = l1.next;
                }
                if (l2 != null)
                {
                    sum += l2.val;
                    l2 = l2.next;
                }
                result.next = new ListNode(sum % 10);
                sum /= 10;
                result = result.next;
            }
            return head.next;
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
}