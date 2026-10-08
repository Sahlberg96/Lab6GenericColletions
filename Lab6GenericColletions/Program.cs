 namespace Lab6GenericColletions
{
    internal class Program
    {
        static void Main(string[] args)
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
            
            foreach (var employee in employeeStack)
            {
 
                employee.PrintStackInfo();
                Console.WriteLine($"Antal anställda kvar: {employeeStack.Count}");
                
                   
            }
           
                
            

            
        }
    }
}
