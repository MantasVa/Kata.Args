using Kata.Args.Infrastructure.Interfaces;
using Kata.Args.Schemas;
using Kata.Args.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kata.Args.Infrastructure.Factories
{
    public class SchemaServiceFactory : ISchemaServiceFactory
    {
        private readonly ISchema schema;
        public SchemaServiceFactory(ISchema schema, string args)
        {
            this.schema = schema;
            CheckSchemaFlags(args);
        }

        private bool CheckSchemaFlags(string args)
        {
            var flagsList = StringParser.GetInputFlags(args);
            if (!StringValidator.CheckForRepeatingFlags(flagsList))
            {
                throw new Exception();
            }

            foreach (string flag in flagsList)
            {
                if (!schema.GetSchema.TryGetValue(flag, out Type type))
                    throw new Exception();
            }

            return true;
        }

        public ISchemaService CreateSchemaService(string args)
        {
            if (schema is DefaultSchema)
            {
                return new DefaultService();
            }
            else if (schema is DateSchema)
            {
                return new DateService();
            }
            else if (schema is DirSchema)
            {
                return new DirService();
            }

            throw new Exception();
        }
    }
}
