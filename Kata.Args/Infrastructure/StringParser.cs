using System;
using System.Collections.Generic;
using System.Text;

namespace Kata.Args.Infrastructure
{
    public static class StringParser
    {
        public static string GetInputCommandType(string args)
        {
            return args.Trim().StartsWith('-') ? "" : args.Trim().Substring(0, args.IndexOf('-')).Trim();
        }

        public static List<string> GetInputFlags(string input)
        {
            List<string> flagsList = new List<string>();
            var flagsChar = input.ToCharArray();

            for (int i = 0; i < flagsChar.Length; i++)
            {
                if (flagsChar[i] == '-' && i < flagsChar.Length - 1)
                {
                    flagsList.Add(flagsChar[i + 1].ToString());
                }
            }

            return flagsList;

        }
    }
}
