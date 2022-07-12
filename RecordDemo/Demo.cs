﻿namespace RecordDemo;

public class Demo
{
    // Immutable - the values cannot be changed
    public record Record1(string FirstName, string LastName);
    public record User1(int Id, string FirstName, string LastName) : Record1(FirstName, LastName);

    public record Record2(string FirstName, string LastName)
    {
        private readonly string _firstName = FirstName;

        public string FirstName
        {
            get => _firstName[..1]+"...";
            init { }
        }

        // public string FirstName { get; init; } = FirstName;
        public string FullName => $"{FirstName} {LastName}";

        public string Greet() => $"Hello {FirstName}";
    }

    public class Class1
    {
        public string FirstName { get; init; }

        public string LastName { get; init; }

        public Class1(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}