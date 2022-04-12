# type: ignore
class Solution:
    def mergeTwoLists(self, list1: Optional[ListNode], list2: Optional[ListNode]) -> Optional[ListNode]:
        outputlist = ListNode()
        current = outputlist
        
        if list1 == None:
            return list2
        elif list2 == None:
            return list1
        
        while list1 and list2:
            if list1.val < list2.val:
                current.next = list1
                list1 = list1.next
            else:
                current.next = list2
                list2 = list2.next
            current = current.next
            
        if list1:
            current.next = list1
        else:
            current.next = list2
        return outputlist.next