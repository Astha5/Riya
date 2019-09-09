using System;
using System.Collections.Generic;


namespace Lab3
{
    class Class2
    {
        static void Main()
        {
            Participant participant = new Participant();
            Console.WriteLine("Enter Emp Id");
            participant.EmpId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Name");
            participant.Name = Console.ReadLine();
            Console.WriteLine("Enter FoundationMarks");
            participant.FoundationMarks = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter WebBasicsMarks");
            participant.WebBasicsMarks = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter DotnetMarks");
            participant.DotnetMarks = int.Parse(Console.ReadLine());

            Console.WriteLine("-----------------------------");
            Console.WriteLine("Emp Id: " + participant.EmpId);
            Console.WriteLine("Name: " + participant.Name);
            Console.WriteLine("Company Name: " + participant.CompanyName);
            Console.WriteLine("FoundationMarks: " + participant.FoundationMarks);
            Console.WriteLine("WebBasicsMarks: " + participant.WebBasicsMarks);
            Console.WriteLine("DotnetMarks: " + participant.DotnetMarks);
            Console.WriteLine("Obtained Marks: " + participant.ObtMarks());
            Console.WriteLine("Percentage: " + participant.Percentage());


        }
    }
}
