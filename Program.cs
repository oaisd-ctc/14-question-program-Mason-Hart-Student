using System;


public class Program
{
    public static void Main(string[] args)
    {
        
        Console.WriteLine("What is your name?");
        string name = Console.ReadLine();
        Console.WriteLine("How old are you?");
        int age = int.Parse(Console.ReadLine());
        Console.WriteLine("what is your eye color?");
        string eyeColor = Console.ReadLine();
        Console.WriteLine("What is your hair color?");
        string hairColor = Console.ReadLine();
        Console.WriteLine("What is your shoe size");
        double shoeSize = double.Parse(Console.ReadLine());
        Console.WriteLine("What is your favorite color?");
        string favColor = Console.ReadLine();
        Console.WriteLine("What is your favorite tv show or movie?");
        string favMovie = Console.ReadLine();
        Console.WriteLine("Who is your favorite teacher?");
        string favTeacher = Console.ReadLine();
        Console.WriteLine("What is your favorite class?");
        string favClass = Console.ReadLine();
        Console.WriteLine("What is your favorite holiday?");
        string favHoliday = Console.ReadLine();
        Console.WriteLine("What is your favorite season?");
        string favSeason = Console.ReadLine();
        Console.WriteLine("What is your dream job?");
        string dreamJob = Console.ReadLine();
        Console.WriteLine("How many siblings do you have?");
        int siblings = int.Parse(Console.ReadLine());

        Console.WriteLine("My friends name is " + name + ". He is " + age + " years old, his eye color is " + eyeColor + ". His hair color is " + hairColor + ", and he wears a size " + shoeSize + " shoe. My friends favorite color is " + favColor + ". His favorite movie/show is " + favMovie + "His favorite teacher is " + favTeacher + ", and his favorite class is " + favClass + ". His favorite holiday is " + favHoliday + ", and his favorite season is " + favSeason + ". His dream job is to be a(n) " + dreamJob + ". In 5 years he will be " + (age + 5) + " years old. He has " + siblings + " siblings");
    }
}
