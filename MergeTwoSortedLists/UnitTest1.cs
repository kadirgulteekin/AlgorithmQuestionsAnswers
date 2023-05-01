namespace MergeTwoSortedLists
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            ListNode list1 = new ListNode(1, new ListNode(2, new ListNode(4)));

            ListNode list2 = new ListNode(1, new ListNode(3, new ListNode(4)));

            var result = MergeTwoList(list1, list2);

            //Assert
            ListNode listExpected = new ListNode(1,new ListNode(1, new ListNode(2,new ListNode
                (3,new ListNode(4,new ListNode(4))))));

        }


        public ListNode MergeTwoList(ListNode list1,ListNode list2)
        {
            ListNode dumppyList = new();
            var testList = dumppyList;

            var newList1 = list1;
            var newList2 = list2;
            while(newList1 != null && newList2 != null)
            {
                if(newList1.val < newList2.val)
                {
                    testList.next = newList1;
                    newList1 = newList1.next;
                }
                else
                {
                    testList.next = newList2;
                    newList2 = newList2.next; 
                }

                testList = testList.next;
            }

            testList.next = newList1 ?? newList2;
            return dumppyList.next;
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
       

        public bool AreEqual(ListNode l1,ListNode l2)
        {
            if(l1 == null && l2 == null)
            {
                return true;
            }
            else if(l1 == null && l2 == null)
            {
               return false;
            }
            else if(l1.val != l2.val)
            {
                return false;
            }
            else
            {
                return AreEqual(l1.next,l2);
            }
        }
    }
}