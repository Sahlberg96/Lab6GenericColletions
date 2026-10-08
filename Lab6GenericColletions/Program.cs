 namespace Lab6GenericColletions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            
            bool isRunning = true;

            while (isRunning)  
            {
                Console.WriteLine("vilken utav metoderna vill du ska skriva ut informationen?");
                Console.WriteLine("1. Stack metoden");
                Console.WriteLine("2. List metoden");
                Console.WriteLine("3. Avsluta programet");
                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Du valde Stack metoden");
                        StackOfEmployees();
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("Du valde List metoden");
                        ListOfEmployees();
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("Tack för din tid");
                        isRunning = false;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("välj mellan 1-3");
                        break;

                }


            }
            

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
                employee.PrintEmployeeInfo();


            }
            Console.WriteLine();

            while (employeeStack.Count > 0) // while loop som kör så länge stacken inte är tom(alltså lika med 0)
            {
                Console.WriteLine($"Antal anställda kvar: {employeeStack.Count}");
                employeeStack.Pop().PrintEmployeeInfo();
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
                employeeStack.Peek().PrintEmployeeInfo();
                Console.WriteLine($"Antal anställda kvar: {employeeStack.Count}");
                employeeStack.Peek().PrintEmployeeInfo();

                if (employeeStack.Contains(employee3))
                {
                    Console.WriteLine($"{employee3.Name} är kvar\n");
                }
                else
                {
                    Console.WriteLine($"{employee3.Name} är inte kvar\n");
                }

            }
            else
            {
                Console.WriteLine("Den här högen är tom");
            }
            Console.WriteLine("alla olika loopar klara");
        }

        public static void ListOfEmployees() // Metod för att hantera allt med listan
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

            if (employees.Contains(employee2)) // för att se om anställda nummer 2 finns i min lista
            {
                Console.WriteLine("Employees2 object exsists in the list");
            }
            else
            {
                Console.WriteLine("The object is not in the list");
            }

            employees.Find(e => e.Gender == "Man").PrintEmployeeInfo(); // hittar den första Mannen i min lista och skriver ut hans info

            

            foreach (var employee in employees.FindAll(e => e.Gender == "Man"))  // hittar alla män i min lista och skriver ut deras info
            {
                
                employee.PrintEmployeeInfo();
            }
            
        }
    }
}
