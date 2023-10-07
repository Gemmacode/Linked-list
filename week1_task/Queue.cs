using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1
{

	public class GemmaQueue<T>
	{

		private MyLinkedList<T> queue;
		public GemmaQueue()
		{
			queue = new MyLinkedList<T>();
		}

		//-------------------------------------------------------------------------------------------------
		public bool IsEmpty()
		{
			if (queue == null)
			{
				return true;
			}
			return false;
		}

		//--------------------------------------------------------------------------------------------------- 
		public void Enqueue(T item)
		{
			queue.Add(item);
		}

		//--------------------------------------------------------------------------------------------------
		public T Dequeue()
		{
			if (IsEmpty())
			{
				Console.WriteLine(("Queue is empty"));
			}
			T item = queue.head.Data;
			queue.Remove(item);
			return item;
		}

		//--------------------------------------------------------------------------------------------------
		public int Size()
		{
			return queue.ListSize();
		}
	}
}