namespace LeetCode._002_Add_Two_Numbers;

public static class AddTwoNumbers
{
    

    public static ListNode AddTwoNumbers_FirstTry(ListNode l1, ListNode l2)
    {
        var c1 = l1;
        var c2 = l2;
        ListNode resFirstNode = new ListNode();
        ListNode previous = resFirstNode;
        ListNode current = resFirstNode;
        int over = 0;
        while (c1 != null || c2 != null || over > 0)
        {
            int val = (c1?.val ?? 0) + (c2?.val ?? 0) + over;
            current.val = val % 10;
            over = val / 10;
            
            if(previous != current) previous.next = current;
            previous = current;
            current = new ListNode();
            //Move to next node
            c1 = c1?.next;
            c2 = c2?.next;
            
        }
        return resFirstNode;
    }


    public static ListNode AddTwoNumbers_Recursion(ListNode l1, ListNode l2)
    {
        ListNode resFirstNode = new ListNode();
        AddNodesFromLinkedList(l1,l2,resFirstNode);
        return resFirstNode;
    }

    private static void AddNodesFromLinkedList(ListNode? l1, ListNode? l2, ListNode node, int over = 0)
    {
        int val = (l1?.val ?? 0) + (l2?.val ?? 0) + over;
        node.val = val % 10;
        int toNext = val / 10;
        
        if (l1?.next != null || l2?.next != null || toNext > 0)
        {
            node.next =  new ListNode();
            AddNodesFromLinkedList(l1?.next, l2?.next, node.next, toNext);
        }
    }
 

}

public class ListNode
{
    public int val;
    public ListNode next;
        
    public ListNode(int val=0, ListNode next=null) 
    {
        this.val = val;
        this.next = next;
    }
}
