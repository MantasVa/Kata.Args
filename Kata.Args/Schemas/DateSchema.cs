using System;
using System.Collections.Generic;
using System.Text;

namespace Kata.Args.Schemas
{
    public class DateSchema : ISchema
    {
        public DateSchema()
        {
            Schema = new Dictionary<string, Type>();
            Schema.Add("l", typeof(void));
            Schema.Add("p", typeof(int));
            Schema.Add("d", typeof(string));
        }
        public Dictionary<string, Type> Schema { get; protected set; }
    }
}
