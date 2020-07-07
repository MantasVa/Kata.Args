using System;
using System.Collections.Generic;

namespace Kata.Args
{
    public interface ISchema
    {
        IDictionary<string, Type> GetSchema { get; }
    }
}