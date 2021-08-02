using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");
  }
  public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {        
        ListNode p=l1;
        ListNode q=l2;
        ListNode temp=new ListNode(-1);
        ListNode curr=temp;
        int carry=0;
        while(p!=null||q!=null){
            int x= (p!=null)? p.val:0;
            int y= (q!=null)?q.val:0;
            int sum=x+y+carry;
            carry=sum/10;
            curr.next=new ListNode(sum%10);
            curr=curr.next;
            if(p!=null){
                p=p.next;
            }
            if(q!=null){
                q=q.next;
            }
        }
        if(carry>0){
            curr.next=new ListNode(carry);
        }
        return temp.next;
        
    }
}