namespace Week1
{
    public class MyLinkedList<T>
    {

        internal GemmaNode<T>? head;
        internal GemmaNode<T>? previous;
        internal GemmaNode<T>? current;
		internal GemmaNode<T>? tail;

		public MyLinkedList()
        {
            head = null;
            previous = null;
            current = null;
			tail = null;	
        }
        //-----------------------------------------------------------------------------------------------
        public void Add(T mydata)
        {
            var newNode = new GemmaNode<T>(mydata);

            if (head is null)
            {
                head = newNode;
				// assign newNode to head because it means the linkedlist is empty.
			}
            else
            {
                current = head;
                while (current.Next != null)
                {

                    current = current.Next;
                }
				current.Next = newNode;     
            }
        }

		public void PrintLinkedList()
		{
			current = head;
			while (current != null)
			{
				Console.WriteLine(current.Data);
				current = current.Next;
			}
		}
		//-----------------------------------------------------------------------------------------------
		public bool Remove(T item)
        {

            while (current != null)
            {
                if (current.Data!.Equals(item))
                {
                    if (previous != null)
                    {
                        previous.Next = current.Next;
                    }
                    else
                    {
                        head = current.Next;
                    }
                    return true;
                }
                previous = current;
                current = current.Next;
            }
            return false;
        }
		//------------------------------------------------------------------------------------------------------

		public bool Check(T item)
		{
			 
			while (current != null)
			{
				if (current.Data!.Equals(item))
				{
					return true;
				}
				current = current.Next;
			}

			return false;
		}
		//-----------------------------------------------------------------------------------------------------

		public int Index(T item)
		{
			 
			int index = 0;

			while (current != null)
			{
				if (current.Data!.Equals(item))
				{
					return -1;
				}
				index++;
				current = current.Next;
			}
			return index;
		}
		//------------------------------------------------------------------------------------------------------

		public T RemoveandPop()
		{
			if (head == null)
			{
				return default!;
			}

			if (head == tail)
			{
				T value = head.Data;
				head = null!;
				tail = null!;
				return value;
			}

			GemmaNode<T> current = head;

			while (current.Next != tail)
			{
				current = current.Next;
			}

			T last_value = tail.Data;

			tail = current;

			tail.Next = null!;

			return last_value;
		}

		//-------------------------------------------------------------------------------------------

		public T LastItem()
		{
			if (tail == null)
			{
				return default!;
			}
			else
			{
				return tail.Data;
			}
		}
		//---------------------------------------------------------------------------------------------

		public int ListSize()
		{
			GemmaNode<T> current = head;
			int count = 0;

			while (current != null)
			{
				count++;
				current = current.Next;
			}

			return count;
		}
		//----------------------------------------------------------------------------------------------
		




	}
		
}