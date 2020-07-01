using Kata.Args.Infrastructure.Factories;
using Kata.Args.Services;
using System;
using System.Runtime.InteropServices;

namespace Kata.Args
{
    class Program
    {
        static void Main(string[] args)
        {
            string args1 = "date -l -d test/ate -p";
            SchemaTypeFactory factory = new SchemaTypeFactory();
            ISchema schema = factory.GetSchema(args1);

            SchemaServiceFactory schemaServiceFactory = new SchemaServiceFactory(schema, args1);
            var service = schemaServiceFactory.CreateSchemaService(args1);

        }
    }
}
