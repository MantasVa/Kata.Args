using Kata.Args.Infrastructure;
using Kata.Args.Infrastructure.Interfaces;
using Kata.Args.Schemas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Kata.Args.Services
{
    public class DateService : ISchemaService
    {
        private DateTime datetime = DateTime.Now;
        private Dictionary<string, Type> schema = new DateSchema().GetSchema;

        public void ExecuteCommand(string input)
        {
            var commandValues = ValidateFlagValues(input);
            foreach (var command in commandValues)
            {
                switch (command.Key.ToLower())
                {
                    case "d":
                        ExecuteFlagD(command.Value);
                        break;
                    case "m":
                        ExecuteFlagM(command.Value);
                        break;
                    case "y":
                        ExecuteFlagY(command.Value);
                        break;
                }
            }

            Console.WriteLine(datetime);
        }

        private Dictionary<string, int> ValidateFlagValues(string input)
        {
            Dictionary<string, string> commandsValues = StringParser.GetInputFlagValues(input);

            Dictionary<string, int> parsedcommandValues = new Dictionary<string, int>();
            foreach (var command in commandsValues)
            {
                Type commandType;
                schema.TryGetValue(command.Key, out commandType);

                if (commandType == typeof(int))
                {
                    int value = int.Parse(command.Value);

                    parsedcommandValues.Add(command.Key, value);

                }
                else
                {
                    throw new Exception();
                }
            }

            return parsedcommandValues;
        }

        private void ExecuteFlagD(int days)
        {
            datetime = datetime.AddDays(days);
        }

        private void ExecuteFlagM(int months)
        {
            datetime = datetime.AddMonths(months);
        }

        private void ExecuteFlagY(int years)
        {
            datetime = datetime.AddYears(years);
        }

    }
}
