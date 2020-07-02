using System;
using System.Collections.Generic;
using System.Text;

namespace Kata.Args.Infrastructure.Interfaces
{
    public interface ISchemaTypeFactory
    {
        public ISchema GetSchema(string args);
    }
}
