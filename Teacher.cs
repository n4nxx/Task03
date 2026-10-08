using System;

public class Teacher
{    private string subject;
    private int yearsOfExperience;

    public string Name { get; set; }

    public string Subject
    {
        get { return subject; }
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
            {
                subject = value;
            }
            else
            {
                subject = "Materia no asignada"; 
            }
        }
    }

    public int YearsOfExperience
    {
        get { return yearsOfExperience; }
        set
        {
            if (value >= 0)
            {
                yearsOfExperience = value;
            }
            else
            {
                yearsOfExperience = 0; 
            }
        }
    }

    public Teacher(string name, string subject, int yearsOfExperience)
    {
        Name = name;
        Subject = subject;
        YearsOfExperience = yearsOfExperience;
    }

    public void ShowProfile()
    {
        Console.WriteLine($"Profesor: {Name} | Materia: {Subject} | Experiencia: {YearsOfExperience} años");
    }
}