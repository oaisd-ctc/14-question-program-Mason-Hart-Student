using System;


public class Program
{
    static string pronouns;
    static string pronouns2;
    static string gender;
    static string name;
    static string age;
    static string eyeColor;
    static string hairColor;
    static string shoeSize;
    static string favoriteColor;
    static string favoriteTVorMovie;
    static string favoriteTeacher;
    static string favoriteClass;
    static string favoriteHoliday;
    static string favoriteSeason;
    static string dreamJob;
    static string numberOfSiblings;
    static int ageIn5Years;

    public static void Main(string[] args)
    {
      AskGender();
      AskName();
      AskAge();
      AskEyeColor();
      AskHairColor();
      AskShoeSize();
      AskFavoriteColor();
      AskFavoriteTvShow();
      AskFavoriteTeacher();
      AskFavoriteClass();
      AskFavoriteHoliday();
      AskFavoriteSeason();
      AskDreamJob();
      CalculateAgeIn5Years(age);
      AskNumberOfSiblings();
      DisplaySummaryMessage();

    }
     public static void AskGender()
     {
       Console.WriteLine("Are you Male or Female?");
       gender = Console.ReadLine();
       if(gender == "Male" || gender == "male")
       {
         pronouns = "He";
         pronouns2 = "his";
       }
       if(gender == "female" || gender == "Female")
       {
         pronouns = "She";
         pronouns2 = "her";
       }
       if(gender != "female" && gender != "Female" && gender != "male" && gender != "Male")
       {
         Console.WriteLine("please restart");
       }
     }
     public static void AskName()
     {
       Console.WriteLine("What is your name?");
       name = Console.ReadLine();
     }
     public static void AskAge()
     {
       Console.WriteLine("What is your age?");
       age = Console.ReadLine();
     }
     public static void AskEyeColor()
     {
       Console.WriteLine("What is your eye color?");
       eyeColor = Console.ReadLine();
     }
     public static void AskHairColor()
     {
       Console.WriteLine("What is your hair color?");
       hairColor = Console.ReadLine();
     }
     public static void AskShoeSize()
     {
       Console.WriteLine("What is your shoe size?");
       shoeSize = Console.ReadLine();
     }
     public static void AskFavoriteColor()
     {
       Console.WriteLine("What is your favorite color?");
       favoriteColor = Console.ReadLine();
     }
     public static void AskFavoriteTvShow()
     {
       Console.WriteLine("What is your favorite tv show or movie?");
       favoriteTVorMovie = Console.ReadLine();
     }
     public static void AskFavoriteTeacher()
     {
       Console.WriteLine("Who is your favorite teacher?");
       favoriteTeacher = Console.ReadLine();
     }
     public static void AskFavoriteClass()
     {
       Console.WriteLine("What is your favorite class?");
       favoriteClass = Console.ReadLine();
     }
     public static void AskFavoriteHoliday()
     {
       Console.WriteLine("What is your favorite holiday?");
       favoriteHoliday = Console.ReadLine();
     }
     public static void AskFavoriteSeason()
     {
       Console.WriteLine("What is your favorite season?");
       favoriteSeason = Console.ReadLine();
     }
     public static void AskDreamJob()
     {
       Console.WriteLine("What is your dream job?");
       dreamJob = Console.ReadLine();
     }
     public static void CalculateAgeIn5Years(string age)
     {
        int.TryParse(age, out int parsedAge);
            ageIn5Years = parsedAge + 5;
     }
     public static void AskNumberOfSiblings()
     {
       Console.WriteLine("How many siblings do you have?");
       numberOfSiblings = Console.ReadLine();
    }
    public static void DisplaySummaryMessage()
    {
        Console.WriteLine($"My friends name is {name}. {pronouns} is {age} years old, {pronouns2} eye color is {eyeColor} and {pronouns2} hair color is {hairColor}. {pronouns} wears a size {shoeSize} shoe, and {pronouns2} favorite color is {favoriteColor}. {pronouns} likes the show/movie {favoriteTVorMovie}, {pronouns2} favorite teacher is {favoriteTeacher}, and {pronouns2} favorite class is {favoriteClass}. My friends favorite holiday is {favoriteHoliday}, and {pronouns2} favorite season is {favoriteSeason}. {pronouns} wants to be a {dreamJob} when they grow up. {pronouns} will be {ageIn5Years} old in 5 years. {pronouns} has {numberOfSiblings} siblings.");
    }
}
