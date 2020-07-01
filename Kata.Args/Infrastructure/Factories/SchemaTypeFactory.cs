using Kata.Args.Infrastructure.Interfaces;
using Kata.Args.Schemas;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kata.Args.Infrastructure.Factories
{
    public class SchemaTypeFactory : ISchemaTypeFactory
    {
        public ISchema GetSchema(string args)
        {
            string commandType = StringParser.GetInputCommandType(args);

            if (commandType == "dir")
            {
                return new DirSchema();

            }
            else if (commandType == "date")
            {
                return new DateSchema();
            }
            else if (commandType == "")
            {
                return new DefaultSchema();

            }
            else
            {
                throw new ArgumentException();
            }
        }
    }
}
