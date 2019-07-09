using System;
using System.Collections.Generic;

namespace the_family_dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            var myFamily = new List<Member>();

            var mother = new Member()
            {
                Relationship = "Mother",
                FirstName = "Dee",
                LastName = "Sandlin",
                Age = 58,
            };

            var father = new Member()
            {
                Relationship = "Father",
                FirstName = "Troy",
                LastName = "Sandlin",
                Age = 56,
            };

            myFamily.Add(father);
            myFamily.Add(mother);

            myFamily.ForEach(member => Console.WriteLine($"{member.FirstName} {member.LastName} is my {member.Relationship} and is {member.Age} years old"));

        }
    }

    class Member
    {
        public string Relationship { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }
}
