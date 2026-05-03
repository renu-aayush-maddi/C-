using System;

class Person
{
    public string Name {get; set;}
    public int Age {get; set;}
    public void Introduce()
    {
        Console.WriteLine("Hello,my name is " + Name + " and I am " + Age + " years old !");
    }
}

class Task2
{
    public static void Run()
    {
        Person p1 = new Person();
        p1.Name = "Aayush";
        p1.Age = 21;

        Person p2 = new Person();
        p2.Name = "Raju";
        p2.Age = 25;

        p1.Introduce();
        p2.Introduce();
    }
}