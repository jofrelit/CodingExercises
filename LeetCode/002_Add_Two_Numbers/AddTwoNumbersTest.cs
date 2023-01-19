using NUnit.Framework;

namespace LeetCode._002_Add_Two_Numbers;

using NUnit;

public class AddTwoNumbersTest
{
    public static ListNode l1_1 = new ListNode()
    {
        val = 9, next = new ListNode()
        {
            val = 9, next = new ListNode()
            {
                val = 9, next = new ListNode()
                {
                    val = 9, next = new ListNode()
                    {
                        val = 9, next = new ListNode()
                        {
                            val = 9, next = new ListNode()
                            {
                                val = 9
                            }
                        }
                    }
                }
            }
        }
    };
    
    public static ListNode l2_1 = new ListNode()
    {
        val = 9, next = new ListNode()
        {
            val = 9, next = new ListNode()
            {
                val = 9, next = new ListNode()
                {
                    val = 9
                }
            }
        }
    };
    
    public static ListNode res_1 = new ListNode()
    {
        val = 8, next = new ListNode()
        {
            val = 9, next = new ListNode()
            {
                val = 9, next = new ListNode()
                {
                    val = 9, next = new ListNode()
                    {
                        val = 0, next = new ListNode()
                        {
                            val = 0, next = new ListNode()
                            {
                                val = 0, next = new ListNode()
                                {
                                    val = 1
                                }
                            }
                        }
                    }
                }
            }
        }
    };


    public static ListNode l1_2 = new ListNode()
    {
        val = 0
    };

    public static ListNode l2_2 = new ListNode()
    {
        val = 0
    };
    
    public static ListNode res_2 = new ListNode()
    {
        val = 0
    };
    
    


    [Test]
    public void TestAddTwoNumbers_FirstTry()
    {
        var resFirstNode1 = AddTwoNumbers.AddTwoNumbers_Recursion(l1_1, l2_1);
        Assert.That(ListIsEqual(resFirstNode1, res_1));
        var resFirstNode2 = AddTwoNumbers.AddTwoNumbers_Recursion(l1_2, l2_2);
        Assert.That(ListIsEqual(resFirstNode2,res_2));
    }
    
    [Test]
    public void TestAddTwoNumbers_Recursion()
    {
        var resFirstNode1 = AddTwoNumbers.AddTwoNumbers_Recursion(l1_1, l2_1);
        Assert.That(ListIsEqual(resFirstNode1, res_1));
        var resFirstNode2 = AddTwoNumbers.AddTwoNumbers_Recursion(l1_2, l2_2);
        Assert.That(ListIsEqual(resFirstNode2,res_2));
    }


    private bool ListIsEqual(ListNode toTry, ListNode expected)
    {
        bool isEqual = true;
        
        while (isEqual)
        {
            if (toTry.val != expected.val)
                isEqual = false;

            if (toTry.next is null && expected.next is null)
                break;

            if (toTry.next is null || toTry.next is null)
            {
                isEqual = false;
                break;
            }
            
            toTry = toTry.next;
            expected = expected.next;

        }

        return isEqual;

    }
}