using System;
using Isen.DotNet.Library;
using Isen.DotNet.Library.Models.Implementation;

namespace Isen.DotNet.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var me = new Person
            {
                FirstName = "Calendau",
                LastName = "Guquet",
                City = new City { Name = "Toulon" },
                BirthDate = new DateTime(1980,2,28)
            };
            me.City.Name = "";
            Console.WriteLine(me);
        }
    }
}
