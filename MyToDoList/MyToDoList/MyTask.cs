using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyToDoList
{
	public class MyTask
	{
		private string mywork;
		private bool isdone;
		private DateTime deadline;

		public MyTask()
		{

		}
		public MyTask(string s, bool b, DateTime d)
		{
			Mywork = s;
			Isdone = b;
			Deadline = d;
		}
		public string Mywork
		{
			get => mywork;
			set => mywork = value;
		}
		public bool Isdone
		{
			get => isdone;
			set => isdone = value;
		}
		public DateTime Deadline
		{
			get => deadline;

			set
			{
				if (value > DateTime.MinValue && value < DateTime.MaxValue)
				{
					deadline = value;
				}
				else
				{
					throw new Exception("Data is invalid");
				}
			}
		}
		public override string ToString()
		{
			return Mywork + "\t" + Isdone + "\t" + Deadline;
		}
	}
}
