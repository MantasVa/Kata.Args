using Kata.Args.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kata.Args.Services
{
    public class Parser
    {
        private readonly ISchema schema;
        public Parser(ISchema schema, string args)
        {
            this.schema = schema;
            CheckSchemaFlags(args);
        }

        private bool CheckSchemaFlags(string args)
        {
            var flagsList = StringParser.GetInputFlags(args);
            return true;
        }

        public void Parse(string args)
        {
            try
            {

            }
            catch
            {

            }
        }
    }
}
