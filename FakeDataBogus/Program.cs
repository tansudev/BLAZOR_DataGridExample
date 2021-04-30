using Bogus;
using System;
using System.Text.Json;
using System.Threading.Tasks;

namespace FakeDataBogus
{
    class Program
    {
        static async Task Main(string[] args)
        {

            var billingfakeData = new Faker<FakeData>()
            .RuleFor(x => x.Id ,x=>x.IndexFaker)
            .RuleFor(x => x.Name, x => x.Person.FullName)
            .RuleFor(x => x.Address, x => x.Person.Address.City)
            .RuleFor(x => x.PostCode, x => x.Person.Address.ZipCode)
            .RuleFor(x => x.Phone, x => x.Person.Phone)
            .RuleFor(x => x.Email, x => x.Person.Email);

           var text = JsonSerializer.Serialize(billingfakeData.Generate());

            foreach (var item in billingfakeData.GenerateForever())
            {
                var textt = JsonSerializer.Serialize(item);
                Console.WriteLine(textt);
                await Task.Delay(1000);
            }
            
            Console.Read();
        }
    }
}
