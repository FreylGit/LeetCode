/*
	Вам даны два непустых связанных списка, представляющих два неотрицательных целых числа. 
	Цифры хранятся в обратном порядке , и каждый из их узлов содержит одну цифру.
	Добавьте два числа и верните сумму в виде связанного списка.
	Вы можете предположить, что эти два числа не содержат начальных нулей, кроме самого числа 0..
*/

/* Пример 1:
	Ввод: l1 = [2,4,3], l2 = [5,6,4]
	Вывод: [7,0,8]
	Объяснение: 342 + 465 = 807.
*/
ListNode l1 = new ListNode(2);
l1.next = new ListNode(4);
l1.next.next = new ListNode(3);

ListNode l2 = new ListNode(5);
l2.next = new ListNode(6);
l2.next.next = new ListNode(4);
var result = AddTwoNumbers(l1, l2);
while (result != null)
{
    Console.Write(result.val);
    result = result.next;
}
static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
{
    var node1Iterator = l1;
    var node2Iterator = l2;
    ListNode result = new ListNode(0);
    var r = result;
    while (node1Iterator != null && node2Iterator != null)
    {
        result.val += node1Iterator.val + node2Iterator.val;
        bool check = false;
        if (result.val >= 10)
        {
            result.val -= 10;
            check = true;
        }
        node1Iterator = node1Iterator.next;
        node2Iterator = node2Iterator.next;

        if (node1Iterator != null || node2Iterator != null)
        {
            if (check)
            {
                result.next = new ListNode(1);
            }
            else
            {
                result.next = new ListNode(0);
            }

            result = result.next;
        }
        else
        {
            if (check)
            {
                result.next = new ListNode(1);
                result = result.next;
            }
        }
    }
    if (node1Iterator != null)
    {
        while (node1Iterator != null)
        {
            result.val += node1Iterator.val;
            if (result.val >= 10)
            {
                result.val -= 10;
                result.next = new ListNode(1);
            }
            else
            {
                if (node1Iterator.next != null)
                {
                    result.next = new ListNode(0);
                }

            }

            result = result.next;
            node1Iterator = node1Iterator.next;
        }
    }
    if (node2Iterator != null)
    {
        while (node2Iterator != null)
        {
            result.val += node2Iterator.val;
            if (result.val >= 10)
            {
                result.val -= 10;

                result.next = new ListNode(1);
            }
            else
            {
                if (node2Iterator.next != null)
                {
                    result.next = new ListNode(0);
                }
            }

            result = result.next;
            node2Iterator = node2Iterator.next;
        }
    }
    if (r.val >= 10)
    {
        r.val -= 10;
        var tmp = new ListNode(1);
        tmp.next = r;
        r = tmp;
    }
    return r;
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
