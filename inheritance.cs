using System;

class Person
{
    public string Name { get;}
    public Person(string name)

    {
     Name = name;
     Console.WriteLine("Person built");
    }
    
}

class Student : Person
{
    public double Gpa { get;}

    public Student(string name, double gpa)
        :base(name)
        {
            Gpa = gpa;
            Console.WriteLine("Student built");
        }
}