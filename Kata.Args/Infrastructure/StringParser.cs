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
                else if (flagsChar[i] == '-' && i == flagsChar.Length - 1)
                {
                    flagsList.Add("");
                }
            }

            return flagsList;
        }

        public static Dictionary<string, string> GetInputFlagValues(string input)
        {
            List<string> flags = GetInputFlags(input);
            List<int> flagsPosition = new List<int>();
            foreach (string flag in flags)
            {
                flagsPosition.Add(input.IndexOf($"-{flag}"));
            }

            Dictionary<string, string> flagsAndValues = new Dictionary<string, string>();

            for (int i = 0; i < flagsPosition.Count; i++)
            {
                int substringStartPosition = flagsPosition[i] + 1;

                if (i != flagsPosition.Count - 1)
                {

                    int substringLength = flagsPosition[i + 1] - flagsPosition[i] - 1;

                    string substring = input.Substring(
                        substringStartPosition,
                        substringLength
                    );

                    flagsAndValues.Add(
                        substring[0].ToString(),
                        substring
                            .Substring(1, substring.Length - 2)
                            .Trim()
                    );
                }
                else
                {
                    string substring = input.Substring(
                        substringStartPosition,
                        input.ToCharArray().Length - flagsPosition[i] - 1
                    );

                    if (substring.Length == 1)
                    {
                        flagsAndValues.Add(
                            substring[0].ToString(),
                            ""
                        );
                    }
                    else
                    {
                        flagsAndValues.Add(
                            substring[0].ToString(),
                            substring.Substring(1, substring.Length - 1)
                                .Trim()
                        );
                    }
                }
            }
            return flagsAndValues;
        }
    }
}
