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
            string args1 = "date -l -d test/ate -";
            SchemaFactory factory = new SchemaFactory();
            factory.GetSchema(args1);
            var parser = new Parser(factory.GetSchema(args1), args1);

        }
    }
}
