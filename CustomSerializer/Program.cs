using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.Json;

namespace CustomSerializer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>
            {
                new Employee
                {
                    Name = "Asgar",
                    Surname = "Babayev",
                    Salary = 1200,
                },
                new Employee
                {
                    Name = "Asgar",
                    Surname = "Babayev",
                    Salary = 1200
                },
            };

            //Employee employee = new Employee
            //{
            //    Name = "Asgar",
            //    Surname = "Babayev",
            //    Salary = 1200
            //};

            var customSerialize = CustomJsonSerializer.Serialize(list);
            Console.WriteLine(customSerialize);

            var defaultSerialize = JsonSerializer.Serialize(list);
            Console.WriteLine(defaultSerialize);

        }
    }
}
