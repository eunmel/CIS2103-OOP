// 1. The main execution code must sit at the top (Top-level statements)
Person[] staff =
{
    new Employee("Mara", 48000),
    new Manager("Ines", 92000, 6),
};

foreach (Person p in staff)
{
    Console.WriteLine(p);
}

// 2. Base Class Definition
class Person
{
    public string Name { get; protected set; }
    
    // Corrected constructor assignment
    protected Person(string name) => Name = name; 

    // Added the missing virtual method so child classes can override it
    public virtual string Describe() => $"{Name}";

    public override string ToString() => Describe();
}

// 3. Child Class Definition
class Employee : Person
{
    public decimal Salary { get; }
    
    public Employee(string name, decimal salary) : base(name)
        => Salary = salary;

    public override string Describe()
        => base.Describe() + $" - earns {Salary:C0}";
}

// 4. Grandchild Class Definition
class Manager : Employee
{
    public int Reports { get; }
    
    public Manager(string name, decimal salary, int reports)
        : base(name, salary) => Reports = reports;

    public sealed override string Describe()
        => base.Describe() + $", leads {Reports}";
}
