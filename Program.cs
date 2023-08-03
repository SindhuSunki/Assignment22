using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Assignment22
{
    public class Program
        {
        static void Main()
        {
            Source source = new Source
            {
               
                Id = 1,
                Name = "John Doe",
                Age = 30
                
            };

            Destination destination = new Destination
            {
                Id = 100,
                Name = "Initial Name",
                Address = "Initial Address"
            };

            PropertyMapper propertyMapper = new PropertyMapper();
            propertyMapper.MapProperties(source, destination);

            // Display the values of the destination object after mapping
            Console.WriteLine("Mapped Destination Object:");
            Console.WriteLine($"Id: {destination.Id}");
            Console.WriteLine($"Name: {destination.Name}");
            Console.WriteLine($"Address: {destination.Address}");
            Console.ReadKey();

        }
        
    }
}