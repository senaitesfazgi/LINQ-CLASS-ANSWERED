using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace LINQ_Practice_Intro
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> intList = SeedIntList();
            List<string> stringList = SeedStringList();
            List<List<int>> nestedList = SeedNestedList();
            List<Person> personList = SeedPersonList();


            // Operating on intList:
            Console.WriteLine($"The sum of the numbers that are greater than or equal to 25: {intList.Where(x=>x>=25).Sum()}.");
            Console.WriteLine($"The lowest number that is divisible by both 2 and 3: {intList.Where(x => x % 2==0 && x % 3 == 0).Min()}.");
            Console.WriteLine($"The average of the numbers that are single digits: {intList.Where(x=> x > 0 && x < 9).Average()}.");
            Console.WriteLine($"The number of distinct numbers starting with 2: {intList}");

            // Operating on stringList:
            Console.WriteLine($"The number of distinct strings (trimmed and case insensitive): {stringList}");
            Console.WriteLine($"The longest string (trimmed): {stringList}.");
            Console.WriteLine($"The second string when ordered in reverse alphabetical order: {stringList}.");

            // Operating on nestedList: 
            Console.WriteLine($"The overall largest number across all lists: {nestedList.ToList().Select((c, i) => i).Max()}.");
            Console.WriteLine($"The number of nested lists: {nestedList.ToList().Count()}.");
            Console.WriteLine($"The number of items in the shortest nested list: {nestedList}.");
            Console.WriteLine($"The average of items in the longest nested list: {nestedList}.");
            Console.WriteLine($"The number of distinct even items across all lists: {nestedList.ToList().Where((c, i) => i % 2 == 0).Count()}.");
            Console.WriteLine($"The average of distinct odd items divisible by either 3 or 5 across all lists: {nestedList.ToList().Where((c, i) => i % 2 == 1 && i % 3 == 0 && i % 5 == 0)}.");

            // Operating on personList: 
            Console.WriteLine($"The number of females in the list: {personList.Where(x => x.Gender == Person.GenderValue.Female).Count()}.");
            Console.WriteLine($"The average number of characters in first names: {personList.Select(x => x.FirstName.Length).Average()}.");
            Console.WriteLine($"The full name of the youngest person: {personList}.");
            Console.WriteLine($"The first name of the person with the longest last name: {personList}.");
            Console.WriteLine($"The gender of the oldest person: {personList}.");



        }

        static List<Person> SeedPersonList()
        {
            return new List<Person>()
            {
                new Person()
                {
                    FirstName = "Bob",
                    LastName = "Jones",
                    DateOfBirth = new DateTime(1992, 02, 12),
                    Gender = Person.GenderValue.Male
                },
                new Person()
                {
                    FirstName = "Sue",
                    LastName = "Smith",
                    DateOfBirth = new DateTime(1983, 6, 18),
                    Gender = Person.GenderValue.Female
                },
                new Person()
                {
                    FirstName = "Tommy",
                    LastName = "Lee",
                    DateOfBirth = new DateTime(1962, 10, 3),
                    Gender = Person.GenderValue.Male
                },
                new Person()
                {
                    FirstName = "Bob",
                    LastName = "Jones",
                    DateOfBirth = new DateTime(1992, 2, 12),
                    Gender = Person.GenderValue.Male
                },
                new Person()
                {
                    FirstName = "Barney",
                    LastName = "The Dinosaur",
                    DateOfBirth = new DateTime(1992, 4, 06),
                    Gender = Person.GenderValue.Male
                },
                new Person()
                {
                    FirstName = "Jane",
                    LastName = "Barber",
                    DateOfBirth = new DateTime(1997, 1, 1),
                    Gender = Person.GenderValue.Female
                },
                new Person()
                {
                    FirstName = "Avery",
                    LastName = "Brown",
                    DateOfBirth = new DateTime(1985, 7, 8),
                    Gender = Person.GenderValue.NotStated
                },
                new Person()
                {
                    FirstName = "Emmett",
                    LastName = "Brown",
                    DateOfBirth = new DateTime(1985, 6, 3),
                    Gender = Person.GenderValue.Male
                },
                new Person()
                {
                    FirstName = "Bob",
                    LastName = "Jones",
                    DateOfBirth = new DateTime(1992, 02, 12),
                    Gender = Person.GenderValue.Male
                },
                new Person()
                {
                    FirstName = "Hermione",
                    LastName = "Granger",
                    DateOfBirth = new DateTime(2001, 11, 16),
                    Gender = Person.GenderValue.Female
                }
            };
        }

        static List<List<int>> SeedNestedList()
        {
            return new List<List<int>>()
            {
                new List<int>() { 42, 12, 3, 7 },
                new List<int>() { 12 },
                new List<int>() { 37, 12, 8, 12, 41, 63, 17, 2, 6, 3 },
                new List<int>() { 90, 100, 12, 7, 17 },
                new List<int>() { 4 * 2, 13 / 3, 90 / 12, 60 % 17, 3 * 3 * 2 }
            };
        }

        static List<string> SeedStringList()
        {
            return new List<string>() { "Yes", "no", "yes", "Yes ", "no", "maybe", "NO", " no", " maYbe ", "definitely" };
        }

        static List<int> SeedIntList()
        {
            return new List<int>() { 3, 10, 2, 3, 12, 7, 12, 12, 24, 42, 101, 3, 25, 42, 60, 72, 5, 2, 100 };
        }
    }
}
