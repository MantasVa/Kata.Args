using System;
using System.Collections.Generic;
using System.Text;

namespace Kata.Args.Schemas
{
    public class DefaultSchema : ISchema
    {
        public DefaultSchema()
        {
            GetSchema = new Dictionary<string, Type>();
            GetSchema.Add("l", typeof(void));
            GetSchema.Add("p", typeof(int));
            GetSchema.Add("d", typeof(string));
        }
        public Dictionary<string, Type> GetSchema { get; protected set; }
    }
}
