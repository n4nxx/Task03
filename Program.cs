using System;
using System.Collections.Generic;

List<Teacher> teachers = new List<Teacher>();
bool running = true;

while (running)
{
    Console.WriteLine("\n=== TeacherSystem ===");
    Console.WriteLine("1. Add teacher");
    Console.WriteLine("2. Show teachers");
    Console.WriteLine("3. Count how many teachers exist");
    Console.WriteLine("4. Show the average years of experience");
    Console.WriteLine("0. Exit");
    Console.Write("Choose an option: ");

    string option = Console.ReadLine();
    Console.WriteLine();

    switch (option)
    {
        case "1":
            Console.Write("Enter name: ");
            string name = Console.ReadLine();
            
            Console.Write("Enter subject: ");
            string subject = Console.ReadLine();
            
            Console.Write("Enter years of experience: ");
            int.TryParse(Console.ReadLine(), out int years);
            
            // Se crea el objeto y se añade a la lista
            teachers.Add(new Teacher(name, subject, years));
            Console.WriteLine("Teacher added successfully.");
            break;

        case "2":
            if (teachers.Count == 0)
            {
                Console.WriteLine("No teachers available.");
            }
            else
            {
                // Se recorre la lista mostrando cada perfil
                foreach (Teacher t in teachers)
                {
                    t.ShowProfile();
                }
            }
            break;

        case "3":
            Console.WriteLine($"Total teachers: {teachers.Count}");
            break;

        case "4":
            if (teachers.Count > 0)
            {
                double totalYears = 0;
                foreach (Teacher t in teachers)
                {
                    totalYears += t.YearsOfExperience;
                }
                double average = totalYears / teachers.Count;
                
                Console.WriteLine($"Average experience: {average} years");
            }
            else
            {
                Console.WriteLine("Add teachers first to calculate the average.");
            }
            break;

        case "0":
            running = false;
            Console.WriteLine("Exiting TeacherSystem...");
            break;

        default:
            Console.WriteLine("Invalid option. Try again.");
            break;
    }
}   