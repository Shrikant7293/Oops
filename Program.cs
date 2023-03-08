using Oops;

public class Program
{
	public static void Main()
	{
		// Simple Function
		//Arthimetic.SimpleFunction(10, 20, 20, 10, 5);



		// Complex Function
		//Arthimetic arthimetic1 = new Arthimetic();
		//arthimetic1.A = 10; arthimetic1.B = 30; arthimetic1.C = 50; arthimetic1.D = 10;

		//Arthimetic arthimetic2 = new Arthimetic();
		//arthimetic2.ComplexFunction(arthimetic1);

		// Input Parameter
		//Arthimetic.AdditionI(11,22);        // Addition
		//Arthimetic.SubstractionI(34,12);    // Substraction
		//Arthimetic.DivisonI(10,20);         // Multiplication


		// Output Parameter
		//int result4;                                  // Additon 
		//Arthimetic.AdditionO(10,30,out result4);

		//int result5;                                  // Substraction
		//Arthimetic.SubstractionO(20,70,out result5);

		//int result6;                                  // Multiplication
		//Arthimetic.MultiplicationO(10,30,out result6);


		// Input/Output Parameter
		Arthimetic arthimetic3= new Arthimetic();

		int result6 = 2;                     // Addition
		arthimetic3.Add(2,3,ref result6);
		Console.WriteLine($"Addition Result = {result6}");

		int result7 = 4;                     // Substraction
		arthimetic3.Sub(4,5,ref result7);
		Console.WriteLine($"Substraction Result = {result7}");

		int result8 = 1;                     // Multiplication
		arthimetic3.Mul(10,4,ref result8);
		Console.WriteLine($"Multiplication Result = {result8}");










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