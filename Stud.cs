using System;
class Student
{
static void Main()
{
Console.Write("Enter Student Id: ");
int id = int.Parse(Console.ReadLine());
Console.Write("Enter Student Name: ");
string name = Console.ReadLine();
Console.Write("Enter Course Name: ");
string course = Console.ReadLine();
Console.Write("Enter Date of Birth: ");
string dob = Console.ReadLine();
Console.WriteLine("\nStudent Information:");
Console.WriteLine("ID: " + id);
Console.WriteLine("Name: " + name);
Console.WriteLine("Course: " + course);
Console.WriteLine("DOB: " + dob);
}
}
