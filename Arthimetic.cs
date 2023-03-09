using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops
{
	internal class Arthimetic
	{
		// Simple Function Demo
		#region Simple Function
		public static void SimpleFunction(int num1,int num2,int num3,int num4,int num5) // Parameter OR Arguments
		{
			int result = num1 + num2 - num3 * num4 / num5;
			Console.WriteLine($"{num1} + {num2} - {num3} * {num4} / {num5} = {result}");
		}
		#endregion

		// Complex Function Demo
		#region Complex Function

		public int A;public int B; public int C; public int D;
		public void ComplexFunction(Arthimetic ArthiMetic) // Object Of a Class
		{
			int result1 = ArthiMetic.A + ArthiMetic.C - ArthiMetic.D * ArthiMetic.B;
			Console.WriteLine($"{ArthiMetic.A} + {ArthiMetic.C} - {ArthiMetic.D} * {ArthiMetic.D} = {result1}");
		}
		#endregion

		// Types Of Parameter

		#region 1.Input Parameter
		public static void AdditionI(int n1,int n2)
		{
			int result3 = n1 + n2;

			Console.WriteLine($"{n1} + {n2} = {result3}");
		}

		public static void SubstractionI(int n3,int n4)
		{
			int result3 = n3 - n4;

			Console.WriteLine($"{n3} - {n4} = {result3}");
		}

		public static void DivisonI(int n5,int n6)
		{
			int result3 = n5 / n6;

			Console.WriteLine($"{n5} / {n6} = {result3}");
		}
		#endregion

		#region 2.Output Parameter

		// Addition
		public static void AdditionO(int nm1,int nm2,out int result4) // Output Parameter
		{
			result4 = nm1 + nm2;
			Console.WriteLine($"Addition Of {nm1} And {nm2} Is = {result4}");
		}

		//Substraction
		public static void SubstractionO(int nb1,int nb2,out int result5)
		{
			result5= nb1 - nb2;
			Console.WriteLine($"Substraction Of {nb1} And {nb2} Is = {result5}");
		}

		//Multiplication
		public static void MultiplicationO(int nub1, int nub2, out int result6)
		{
			result6 = nub1 * nub2;
			Console.WriteLine($"Multiplication Of {nub1} And {nub2} Is = {result6}");
		}
		#endregion

		#region 3. Input/Output Parameter

		public void Add(int w,int x,ref int result6) // Addition
		{
			result6 = result6 + w + x;
		}

		public void Sub(int r, int s, ref int result7) // Substraction
		{
			result7 = result7 - r - s;
		}

		public void Mul(int g, int h, ref int result8) // Multiplication
		{
			result8 = result8 * g * h;
		}
		#endregion

	}
}
