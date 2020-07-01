using System;
using System.Collections.Generic;
using System.Text;

namespace Kata.Args.Infrastructure
{
    public static class StringValidator
    {
        public static bool CheckForRepeatingFlags(List<string> flagsList)
        {
            List<string> flagsCopyList = new List<string>();

            foreach (string flag in flagsList)
            {
                foreach (string flagCopy in flagsCopyList)
                {
                    if (flag.ToLower() == flagCopy.ToLower()) return false;
                }
                flagsCopyList.Add(flag);
            }

            return true;
        }

    }
}
