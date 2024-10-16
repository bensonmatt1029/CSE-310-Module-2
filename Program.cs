using System;
using System.Collections.Generic;

class Program
{
    // Class to represent Employee attributes
    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }

        public Employee(int id, string name, string position)
        {
            ID = id;
            Name = name;
            Position = position;
        }

        public void DisplayEmployeeInfo()
        {
            Console.WriteLine($"ID: {ID}, Name: {Name}, Position: {Position}");
        }
    }

    // List to store employees
    static List<Employee> employees = new List<Employee>();

    static void Main(string[] args)
    {
        bool running = true;
        while (running)
        {
            Console.WriteLine("\nEmployee Management System");
            Console.WriteLine("1. Add Employee");
            Console.WriteLine("2. Edit Employee");
            Console.WriteLine("3. Display Employees");
            Console.WriteLine("4. Delete Employee");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    AddEmployee();
                    break;
                case "2":
                    EditEmployee();
                    break;
                case "3":
                    DisplayEmployees();
                    break;
                case "4":
                    DeleteEmployee();
                    break;
                case "5":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

    // Function to add an employee
    static void AddEmployee()
    {
        Console.Write("Enter Employee ID: ");
        int id = int.Parse(Console.ReadLine());

        Console.Write("Enter Employee Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Employee Position: ");
        string position = Console.ReadLine();

        Employee newEmployee = new Employee(id, name, position);
        employees.Add(newEmployee);
        Console.WriteLine("Employee added successfully.");
    }

    // Function to edit an employee's details
    static void EditEmployee()
    {
        Console.Write("Enter Employee ID to edit: ");
        int id = int.Parse(Console.ReadLine());

        Employee employee = employees.Find(e => e.ID == id);
        if (employee != null)
        {
            Console.Write("Enter new name (leave blank to keep current): ");
            string newName = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(newName))
            {
                employee.Name = newName;
            }

            Console.Write("Enter new position (leave blank to keep current): ");
            string newPosition = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(newPosition))
            {
                employee.Position = newPosition;
            }

            Console.WriteLine("Employee details updated.");
        }
        else
        {
            Console.WriteLine("Employee not found.");
        }
    }

    // Function to display all employees
    static void DisplayEmployees()
    {
        Console.WriteLine("\nEmployee List:");
        foreach (var employee in employees)
        {
            employee.DisplayEmployeeInfo();
        }
    }

    // Function to delete an employee
    static void DeleteEmployee()
    {
        Console.Write("Enter Employee ID to delete: ");
        int id = int.Parse(Console.ReadLine());

        Employee employee = employees.Find(e => e.ID == id);
        if (employee != null)
        {
            employees.Remove(employee);
            Console.WriteLine("Employee deleted.");
        }
        else
        {
            Console.WriteLine("Employee not found.");
        }
    }
}