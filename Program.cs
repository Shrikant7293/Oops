﻿using Oops;

public class Program
{
	public static void Main()
	{
		Student student = new Student();
		student.GetData();
		student.PutData();
		
		// School();

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