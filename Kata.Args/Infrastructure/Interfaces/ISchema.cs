using System;
using System.Collections.Generic;

namespace Kata.Args
{
    public interface ISchema
    {
        Dictionary<string, Type> Schema { get; }
    }
}