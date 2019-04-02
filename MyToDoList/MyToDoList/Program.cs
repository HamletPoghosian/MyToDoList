using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyToDoList
{
	class Program
	{
		static void Main(string[] args)
		{
			MyToDoList my=new MyToDoList();
			MyTask my1 = new MyTask();
			my.Add(new MyTask("vazgen", true, DateTime.Now));
			my.Add(my1);
			
			Console.WriteLine( my.MyContains(new MyTask("vazgen", true, DateTime.Now)));
			foreach (MyTask item in my)
			{
				Console.WriteLine(item);
			}
		}
	}
}
