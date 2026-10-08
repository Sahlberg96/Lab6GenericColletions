using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6GenericColletions
{
    internal class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public double Salary { get; set; }
        public Employee(int iD, string name, string gender, double salary)
        {
            ID = iD;
            Name = name;
            Gender = gender;
            Salary = salary;
        }

        public void PrintStackInfo() // Kallar på denna metod med Pop eller Peek så att konsollen skriver ut mina anställda och deras information
        {
            Console.WriteLine($"ID: {ID}");
            Console.WriteLine($"Namn: {Name}");
            Console.WriteLine($"Kön: {Gender}");
            Console.WriteLine($"Lön: {Salary}\n");


        }

        
    }
}
