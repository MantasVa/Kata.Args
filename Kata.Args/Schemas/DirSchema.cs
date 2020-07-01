using System;
using System.Collections.Generic;
using System.Text;

namespace Kata.Args.Schemas
{
    public class DirSchema : ISchema
    {
        public DirSchema()
        {
            GetSchema = new Dictionary<string, Type>();
            GetSchema.Add("l", typeof(void));
            GetSchema.Add("p", typeof(int));
            GetSchema.Add("d", typeof(string));
        }
        public Dictionary<string, Type> GetSchema { get; protected set; }
    }
}
