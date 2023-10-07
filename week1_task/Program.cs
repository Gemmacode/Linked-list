using Week1;

namespace week1_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var jemyLinkedlist = new MyLinkedList<int>();

            jemyLinkedlist.Add(9);
            jemyLinkedlist.Add(67);
            jemyLinkedlist.Add(6);
            var k = jemyLinkedlist.Index(6);
            Console.WriteLine(k);
            //jemyLinkedlist.Remove(6); // Only remove items from a linkedlist through the tail.
            jemyLinkedlist.PrintLinkedList(); // for printing the linkedlist

            //var ind = jemyLinkedlist.Index(9);
            //Console.WriteLine(ind);

            //var k = jemyLinkedlist.Check(67);
            //Console.WriteLine(k);

            ////-----------------------------------------------------------------------

            //var myQueue = new GemmaQueue<int>();
            //myQueue.Enqueue(9);
            //myQueue.Enqueue(18);  //// Add to the queue
            //myQueue.Enqueue(80);

            //int dequeuedItem = myQueue.Dequeue();  //// remove from front queue
            //Console.WriteLine(dequeuedItem);

            //var size = myQueue.Size();
            //Console.WriteLine(size); // number of elements in the queue

            ////-----------------------------------------------------------

            //var myStack = new GemmaStack<int>();
            //myStack.Push(18);
            //myStack.Push(4);
            //myStack.Push(5);
            //bool isEmpty = myStack.IsEmpty();
            //Console.WriteLine(isEmpty);
            //int poppedItem = myStack.Pop();
            //Console.WriteLine(poppedItem);
            //myStack.Peek();

            //------------------------------------------------------------
        }
    }
}