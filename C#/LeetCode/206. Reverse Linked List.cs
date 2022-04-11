using System.Collections.Generic;
//Itarively
public class Solution {
    public ListNode ReverseList(ListNode head) 
    {
        ListNode current = head;
        ListNode previous = null;

        while (current != null)
        {
            ListNode next = current.next;
            current.next = previous;
            previous = current;
            current = next;
            
        }
        return previous;
    }
}