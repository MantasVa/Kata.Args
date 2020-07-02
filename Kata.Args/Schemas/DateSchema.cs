using System;
using System.Collections.Generic;
using System.Text;

namespace Kata.Args.Schemas
{
    public class DateSchema : ISchema
    {
        public DateSchema()
        {
            GetSchema = new Dictionary<string, Type>();
            GetSchema.Add("d", typeof(int));
            GetSchema.Add("m", typeof(int));
            GetSchema.Add("y", typeof(int));
        }
        public Dictionary<string, Type> GetSchema { get; protected set; }
    }
}
