using System;
using System.Linq;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method)]
public class ExecutiableAttribute : Attribute{}

public class MathOperations
{
    [Executiable]
    public void Add()
    {
        Console.WriteLine("Addition: "+(10+20));
    }

    public void Subtract()
    {
        Console.WriteLine("Subtraction: " + (20-10));
    }
}

public class Greeting
{
    [Executiable]
    public void SayHello()
    {
        Console.WriteLine("Hello World");
    }

    [Executiable]
    public void Welcome()
    {
        Console.WriteLine("Welcome to Reflection");
    }
}

public class Program
{
    public static void Main()
    {
        Assembly assembly = Assembly.GetExecutingAssembly();

        var runnableMethods = assembly.GetTypes()
            .SelectMany(type => type.GetMethods())
            .Where(method => method.GetCustomAttribute<ExecutiableAttribute>() != null);

        foreach (var method in runnableMethods)
        {
            Console.WriteLine("Executing:" + method.Name);
            object instance = Activator.CreateInstance(method.DeclaringType);
            method.Invoke(instance, null);
            Console.WriteLine();
        }
    }
}