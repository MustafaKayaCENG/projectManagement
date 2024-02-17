using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        User user1 = new User("123", "Chamb", "CHA", "Cham.cha@example.com");
        User user2 = new User("456", "Carly", "CAR", "Carly.car@example.com");

        Task task1 = new Task("To learn OOP concepts in c#", "Making projects", DateTime.Now, DateTime.Now.AddDays(7));
        Task task2 = new Task("To make projects", "Learning OOP concepts", DateTime.Now.AddDays(1), DateTime.Now.AddDays(14));

        Project project = new Project("To learn OOP concepts in c#", "Making projects", DateTime.Now, DateTime.Now.AddDays(30));
        project.Users.Add(user1);
        project.Users.Add(user2);
        project.Tasks.Add(task1);
        project.Tasks.Add(task2);

        Console.WriteLine("Project Name: " + project.Name);
        Console.WriteLine("Project Description: " + project.Description);
        Console.WriteLine("Start Date: " + project.StartDate);
        Console.WriteLine("End Date: " + project.EndDate);

        Console.WriteLine("\nTasks:");
        foreach (Task task in project.Tasks)
        {
            Console.WriteLine("Task Name: " + task.Name);
            Console.WriteLine("Task Description: " + task.Description);
            Console.WriteLine("Start Date: " + task.StartDate);
            Console.WriteLine("End Date: " + task.EndDate);
        }

        Console.WriteLine("\nUsers:");
        foreach (User user in project.Users)
        {
            Console.WriteLine("First Name: " + user.FirstName);
            Console.WriteLine("Last Name: " + user.LastName);
            Console.WriteLine("Email: " + user.Email);
        }
    }
}
public class Project
{
    public string Name { get; set; }
    public string Description { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public List<Task> Tasks { get; set; }
    public List<User> Users { get; set; }

    public Project(string name, string description, DateTime startDate, DateTime endDate)
    {
        Name = name;
        Description = description;
        StartDate = startDate;
        EndDate = endDate;
        Tasks = new List<Task>();
        Users = new List<User>();
    }
}
public class Task
{
    public string Name { get; set; }
    public string Description { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }

    public Task(string name, string description, DateTime startDate, DateTime endDate)
    {
        Name = name;
        Description = description;
        StartDate = startDate;
        EndDate = endDate;
    }
}
public class User
{ 
    public string Password { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }

    public User(string password, string firstName, string lastName, string email)
    {
        Password = password;
        FirstName = firstName;
        LastName = lastName;
        Email = email;
    }
}

