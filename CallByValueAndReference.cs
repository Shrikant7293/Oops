using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops
{
	internal class CallByValueAndReference
	{
		#region Call By Value
		public void CallByValue(int A,int B)
		{
			A = 1;
			B = 2;
			Console.WriteLine($"Number1 = {A} And Number2 = {B}");
		}
		#endregion

		#region Call By Reference
		public void CallByReference(ref int A,ref int B)
		{
			A = 10;
			B = 20;
			Console.WriteLine($"Number1 = {A} And Number2 = {B}");
		}
		#endregion
	}
}
