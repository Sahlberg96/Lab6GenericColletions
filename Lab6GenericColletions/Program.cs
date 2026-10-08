 namespace Lab6GenericColletions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StackOfEmployees();


        }

        public static void StackOfEmployees() // Hanterar allt som har med Stack delen att göra
        {
            Employee employee1 = new Employee(3456, "Daniel", "Man", 35000);
            Employee employee2 = new Employee(4672, "Bertil", "Man", 67000);
            Employee employee3 = new Employee(1134, "Claudia", "Kvinna", 29000);
            Employee employee4 = new Employee(5233, "Nathalie", "Kvinna", 32000);
            Employee employee5 = new Employee(10424, "Joakim", "Man", 55000);
            Stack<Employee> employeeStack = new Stack<Employee>();

            employeeStack.Push(employee1);
            employeeStack.Push(employee2);
            employeeStack.Push(employee3);
            employeeStack.Push(employee4);
            employeeStack.Push(employee5);

            foreach (var employee in employeeStack) // Foreach loop som skriver ut all de anställda i stacken
            {

                Console.WriteLine($"Antal anställda kvar: {employeeStack.Count}");
                employee.PrintStackInfo();


            }
            Console.WriteLine("Foreach loppen klar\n"); // göra det tydligare när koden går till nästa loop

            while (employeeStack.Count > 0) // while loop som kör så länge stacken inte är tom(alltså lika med 0)
            {
                Console.WriteLine($"Antal anställda kvar: {employeeStack.Count}");
                employeeStack.Pop().PrintStackInfo();
            }
            employeeStack.Push(employee1);
            employeeStack.Push(employee2);
            employeeStack.Push(employee3);
            employeeStack.Push(employee4);
            employeeStack.Push(employee5);


            Console.WriteLine($"La tillbaka {employeeStack.Count} i högen\n");

            if (employeeStack.Count != 0) //ifall min stack inte är tom så går vi in i if satsen och skriver ut iformationen i loopen
            {

                Console.WriteLine($"Antal anställda kvar: {employeeStack.Count}");
                employeeStack.Peek().PrintStackInfo();
                Console.WriteLine($"Antal anställda kvar: {employeeStack.Count}");
                employeeStack.Peek().PrintStackInfo();

                if (employeeStack.Contains(employee3))
                {
                    Console.WriteLine($"{employee3.Name} är kvar");
                }
                else
                {
                    Console.WriteLine($"{employee3.Name} är inte kvar");
                }

            }
            else
            {
                Console.WriteLine("Den här högen är tom");
            }
            Console.WriteLine("alla olika loopar klara");
        }

        public static void ListOfEmployees()
        {
            Employee employee1 = new Employee(3456, "Daniel", "Man", 35000);
            Employee employee2 = new Employee(4672, "Bertil", "Man", 67000);
            Employee employee3 = new Employee(1134, "Claudia", "Kvinna", 29000);
            Employee employee4 = new Employee(5233, "Nathalie", "Kvinna", 32000);
            Employee employee5 = new Employee(10424, "Joakim", "Man", 55000);

            List<Employee> employees = new List<Employee>();

            employees.Add(employee1);
            employees.Add(employee2);
            employees.Add(employee3);
            employees.Add(employee4);
            employees.Add(employee5);

            if (employees.Contains(employee2))
            {
                Console.WriteLine("Employees2 object exsists in the list");
            }
            else
            {
                Console.WriteLine("The object is not in the list");
            }
        }
    }
}
