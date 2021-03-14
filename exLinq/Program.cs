using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace exLinq
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] nums = {1, 2, 3, 4, 5, 6, 7, 8};
            var sorted = from num in nums where num % 2 == 0 select num;
            foreach (var VARIABLE in sorted)
            {
               // Console.WriteLine(VARIABLE);
            }
            List<User> users = new List<User>
            {
                new User {Name="Том", Age=23, Languages = new List<string> {"английский", "немецкий" }},
                new User {Name="Боб", Age=27, Languages = new List<string> {"английский", "французский" }},
                new User {Name="Джон", Age=29, Languages = new List<string> {"английский", "испанский" }},
                new User {Name="Элис", Age=24, Languages = new List<string> {"испанский", "немецкий" }}
            };

            var selectedUsers = from user in users where user.Age > 25 select user;
            foreach (var user in selectedUsers)
            {
                Console.WriteLine($"{user.Name}-{user.Age}");
            }

            Console.WriteLine("-----------------------------------------");

            var selectedUser = from user in users 
                from lang in user.Languages where lang == "английский" select user;
            foreach (var user in selectedUser)
            {
                Console.WriteLine($"{user.Name}-{user.Age}");
            }
            Console.WriteLine("-----------------------------------------");
            var userMr = from user in users
                let name = "Уважаемый " + user.Name
                select new
                {
                    Name = name,
                    Age = user.Age,
                    Languages = user.Languages
                };
            foreach (var user in userMr)
            {
                Console.WriteLine($"{user.Name}-{user.Age}");
            }
            Console.WriteLine("-----------------------------------------");
            int[] numbers = { 3, 12, 4, 10, 34, 20, 55, -66, 77, 88, 4 };
            // var ordered = from i in numbers orderby i  select i;
            var ordered = numbers.OrderBy(i => i);
             foreach (var number in ordered)
             {
                 Console.Write($"{number} ");
             }
            

        }
    }
}