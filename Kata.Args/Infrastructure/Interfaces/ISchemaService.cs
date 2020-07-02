using System;
using System.Collections.Generic;
using System.Text;

namespace Kata.Args.Infrastructure.Interfaces
{
    public interface ISchemaService
    {
        void ExecuteCommand(string input);
    }
}
