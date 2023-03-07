using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops
{
	internal class Doctor
	{
		// Non-Static Members / Data member / Instance Member
		public int Id { get; set; }
		public string Name { get; set; }
		public int GrossIncome { get; set; }
		public int SalaryIncomeTax { get; set; }

		// Static Members / Data member / Instance Member
		public static int NetIncome { get;set; }

		#region Non Returing Function And Returing Function

		// Non Value Returing Function

		public void GetData()
		{
			
			Console.WriteLine("Enetr Doctor Id");
			Id = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Enter Doctor Name");
			Name = Console.ReadLine();

			Console.WriteLine("Enter Doctor GorssIncome");
			GrossIncome = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Enter Doctor SalaryIncome");
			SalaryIncomeTax = Convert.ToInt32(Console.ReadLine());

			NetIncome = CalculateNetIncome();
		}

		public void PutData()
		{
			Console.WriteLine("Doctor Id =" + Id);
			Console.WriteLine("Doctor Name =" + Name);
			Console.WriteLine("Doctor GrossIncome =" + GrossIncome);
			Console.WriteLine("Doctor SalaryIncomeTax =" + SalaryIncomeTax);
			Console.WriteLine("Doctor NetIncome =" + NetIncome);
		}

		// Value Returning Function
		public int CalculateNetIncome()
		{
			NetIncome = GrossIncome - SalaryIncomeTax;
			return NetIncome;
		}
		#endregion

		#region Type Casting Demo
		// Type Casting Demo
		public string strId { get; set; }
		public char charId { get; set; }

		public static void TypeCasting()
		{
			Doctor doctor = new Doctor();

			doctor.strId = "120";
			doctor.Id=Convert.ToInt32(Console.ReadLine());   // Implicit Typecasting

			doctor.charId = 'b';
			doctor.Id = doctor.charId;                       // Explicit Typecasting
		}
		#endregion


	}
}
