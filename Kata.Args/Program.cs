using Kata.Args.Infrastructure.Factories;
using Kata.Args.Infrastructure.Interfaces;
using Kata.Args.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Runtime.InteropServices;

namespace Kata.Args
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
                .AddSingleton<ISchemaTypeFactory, SchemaTypeFactory>()
                .AddSingleton<ISchemaServiceFactory, SchemaServiceFactory>()
                .BuildServiceProvider();


            Console.WriteLine("Enter Command: ");
            string input = Console.ReadLine();

            var schemaTypeFactory = serviceProvider.GetRequiredService<ISchemaTypeFactory>();
            ISchema schema = schemaTypeFactory.GetSchema(input);

            var schemaServiceFactory = serviceProvider.GetRequiredService<ISchemaServiceFactory>();
            var service = schemaServiceFactory.CreateSchemaService(schema, input);

            service.ExecuteCommand(input);


            Console.ReadLine();
        }
    }
}
