using System;
using System.Collections.Generic;
using System.Text;

namespace Kata.Args.Schemas
{
    public class DefaultSchema : ISchema
    {
        /// <summary>
        /// 
        /// -l
        /// -p <default> / int
        /// -d <current> / string
        /// 
        /// 
        /// -l -d -p 50
        /// -l -d 80 -p
        /// 
        /// </summary>
        public DefaultSchema()
        {
            Schema = new Dictionary<string, Type>();
            Schema.Add("l", typeof(void));
            Schema.Add("p", typeof(int));
            Schema.Add("d", typeof(string));
        }
        public Dictionary<string, Type> Schema { get; protected set; }
    }
}
