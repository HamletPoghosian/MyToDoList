using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyToDoList
{
	public class MyToDoList : IEnumerable<MyTask>
	{
		private List<MyTask> list = new List<MyTask>();


		public void Add(MyTask mytask)
		{
			list.Add(mytask);

		}
		public void Del(MyTask mytask)
		{
			list.Remove(mytask);
		}
		public void AddtoIndex(MyTask mytask, int index)
		{
			if (index > list.Count)
			{
				throw new IndexOutOfRangeException();
			}
			else
			{
				list.Insert(index, mytask);
			}
		}
		public IEnumerator GetEnumerator()
		{
			for (int i = 0; i < list.Count; i++)
			{
				yield return list[i];
			}
		}
		public List<MyTask> ShowCompletit(MyToDoList todo)
		{
			return todo.Where(x => x.Isdone == true).ToList();


		}
		IEnumerator<MyTask> IEnumerable<MyTask>.GetEnumerator()
		{
			return list.GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			throw new NotImplementedException();
		}
	}
}
