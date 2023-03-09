using Oops;

public class Program
{
	public static void Main()
	{
		#region Call By Value And Call By Reference
		int a = 10;
		int b = 3;

		// Call By Value
		CallByValueAndReference callByValue = new CallByValueAndReference();
		callByValue.CallByValue(a, b);

		// Call By Reference
		CallByValueAndReference callByReference = new CallByValueAndReference();
		callByReference.CallByReference(ref a,ref b);


		#endregion


		#region Actual Parameter
		//ReturnValueFunction returnValueFunction = new ReturnValueFunction();
		//int result;
		//int num1 = 9, num2 = 10;  // Actual Parameter
		//returnValueFunction.FormalParameter(num1,num2,out result);
		#endregion

		#region Return Output Parameter
		// Return Output Parameter
		//ReturnValueFunction returnValueFunction1= new ReturnValueFunction();
		//int result;
		// returnValueFunction1.ReturnOutputParameter(20, 30,out result); 

		// Return With Actual Output Parameter
		//ReturnValueFunction returnValueFunction2= new ReturnValueFunction();
		//String Fn = "Ajay", Ln = "Devgan";
		//string F;
		//returnValueFunction2.ReturnWithFormalOutputParameter1(Fn, Ln,out F);

		// Multiple Variable But Return With One Variable
		//ReturnValueFunction returnValueFunction3 = new ReturnValueFunction();

		//int AdditionResult = returnValueFunction3.ReturnOneVariable(30, 35, out int Substraction,
		//					  out int Multiplication, out int Division, out int Mod);
		//Console.WriteLine($"Addition = {AdditionResult}\nSubstraction = {Substraction}\n" +
		//	             $"Mutiplication = {Multiplication}\nDivision = {Division}\n" +
		//				 $"Mod = {Mod}");
		#endregion

		#region Return Input/Output Parameter
		//Return Value Parameter
		//ReturnValueFunction returnValueFunction4= new ReturnValueFunction();
		//int nmb3 = 3;
		//returnValueFunction4.ReturnInputOutputParameter(20, 30, ref nmb3);

		//Return With Actual Parameter
		//ReturnValueFunction returnValueFunction5= new ReturnValueFunction();
		//string Fst = "Jay", Lst = "Shirkar";
		//string ReturnInputOutputParameterResult = returnValueFunction5.ReturnFormalInputOutputParameter(Fst,ref Lst);
		//Console.WriteLine($"FirstName = {Fst} LastName = {Lst}\nFullName = {ReturnInputOutputParameterResult}");
		#endregion




		#region Simple Function
		// Simple Function
		//Arthimetic.SimpleFunction(10, 20, 20, 10, 5);
		#endregion

		#region Complex Function
		// Complex Function
		//Arthimetic arthimetic1 = new Arthimetic();
		//arthimetic1.A = 10; arthimetic1.B = 30; arthimetic1.C = 50; arthimetic1.D = 10;

		//Arthimetic arthimetic2 = new Arthimetic();
		//arthimetic2.ComplexFunction(arthimetic1);
		#endregion

		// Types Of Parameter

		#region 1.Input Parameter
		// Input Parameter
		//Arthimetic.AdditionI(11,22);        // Addition
		//Arthimetic.SubstractionI(34,12);    // Substraction
		//Arthimetic.DivisonI(10,20);         // Multiplication
		#endregion

		#region 2.Output Parameter
		// Output Parameter
		//int result4;                                  // Additon 
		//Arthimetic.AdditionO(10,30,out result4);

		//int result5;                                  // Substraction
		//Arthimetic.SubstractionO(20,70,out result5);

		//int result6;                                  // Multiplication
		//Arthimetic.MultiplicationO(10,30,out result6);
		#endregion

		#region 3.Input/Output Parameter
		// Input/Output Parameter
		//Arthimetic arthimetic3 = new Arthimetic();

		//int result6 = 2;                     // Addition
		//arthimetic3.Add(2,3,ref result6);
		//Console.WriteLine($"Addition Result = {result6}");

		//int result7 = 4;                     // Substraction
		//arthimetic3.Sub(4,5,ref result7);
		//Console.WriteLine($"Substraction Result = {result7}");

		//int result8 = 1;                     // Multiplication
		//arthimetic3.Mul(10,4,ref result8);
		//Console.WriteLine($"Multiplication Result = {result8}");
		#endregion



		// Non- Returning Function And Returning Function

		//Console.WriteLine("Object1");
		//Doctor doctor1 = new Doctor();
		//doctor1.GetData();
		//doctor1.PutData();

		//Console.WriteLine();

		//Console.WriteLine("Object2");
		//Doctor doctor2 = new Doctor();
		//doctor2.GetData();
		//doctor2.PutData();

		// Typecasting
		//Doctor.TypeCasting();

		//Student student = new Student();    // Non-Static Function
		//student.GetData();
		//student.PutData();

		// School();              // Static Function
	}

	public static void School()
	{
		Student student1 = new Student();
		student1.Id = 1;
		student1.Name = "Ram";
		student1.Class = 12;

		Console.WriteLine("Student ID = " + student1.Id);
		Console.WriteLine("Student Name = " + student1.Name);
		Console.WriteLine("Student Class = " + student1.Class);

		Student student2;
		student2 = new Student();

		Console.WriteLine("Enter Student ID");
		student2.Id = Convert.ToInt32(Console.ReadLine());

		Console.WriteLine("Enter Student Name");
		student2.Name = Console.ReadLine();

		Console.WriteLine("Enter Student Class");
		student2.Class = Convert.ToInt32(Console.ReadLine());

		Console.WriteLine("Student ID = " + student2.Id);
		Console.WriteLine("Student Name = " + student2.Name);
		Console.WriteLine("Student Class = " + student2.Class);
	}
}