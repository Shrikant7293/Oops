using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops
{
	internal class ReturnValueFunction
	{
		#region Formal Output Parameter
		public void FormalParameter(int nb1,int nb2,out int nb3) // Formal Parameter
		{
			nb3=nb1 + nb2;
			Console.WriteLine($"Result {nb3}");
		}
		#endregion

		#region Return Output Parameter
		// Return Output Parameter
		public int ReturnOutputParameter(int num1,int num2,out int result)
		{
		    result = num1 * num2;
			Console.WriteLine($"Multiplication Of {num1} And {num2} Is = {result}");
			return result;
		}
		// Return With Formal Parameter
		public string ReturnWithFormalOutputParameter1(string FsN,string LsN,out String Fn) // Formal Parameter
		{
			Fn = FsN +" "+ LsN;
			Console.WriteLine($"First Name = {FsN} And Last Name = {LsN}\nFullName = {Fn}");
			return Fn;
		}

		// Multiple Variable But Return With One Variable
		public int ReturnOneVariable(int a, int b, out int Substraction,
		out int Multiplication, out int Divisoin, out int Mod)
		{
			int Addition = a + b;
			Substraction = a - b;
			Multiplication = a * b;
			Divisoin = a / b;
			Mod = a % b;

			return Addition;
		}

		#endregion

		#region Return Input/Output Parameter
		// Return Value Parameter
		public int ReturnInputOutputParameter(int nmb1,int nmb2,ref int nmb3)
		{
			nmb3 = nmb3 + nmb1 * nmb2;
			Console.WriteLine($"Addition Of {nmb1} And {nmb2} Is = {nmb3}"); 
			return nmb3;
		}

		//Return With Formal Parameter
		public string ReturnFormalInputOutputParameter(string FirstName,ref string LastName)
		{
			string FullName = FirstName + " " + LastName;	
			return FullName;
		}
		#endregion
	}
}
