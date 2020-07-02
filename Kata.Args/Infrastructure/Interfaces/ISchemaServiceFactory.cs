using System;
using System.Collections.Generic;
using System.Text;

namespace Kata.Args.Infrastructure.Interfaces
{
    public interface ISchemaServiceFactory
    {
        ISchemaService CreateSchemaService(ISchema schema, string args);
    }
}
