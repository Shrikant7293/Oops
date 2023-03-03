using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops
{
	internal class Student
	{
		public int Id { get; set; }

		public String Name { get; set; }

		public int Class { get; set; }

		public void GetData()
		{
			Console.WriteLine("Enter Student ID");
			this.Id = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Enter Student Name");
			this.Name = Console.ReadLine();

			Console.WriteLine("Enter Student Class ");
			this.Class = Convert.ToInt32(Console.ReadLine());
		}

		public void PutData()
		{
			Console.WriteLine("Student ID = " + this.Id);

			Console.WriteLine("Student Name = " + this.Name);

			Console.WriteLine("Student Class = " + this.Class);
		}
	}
}
