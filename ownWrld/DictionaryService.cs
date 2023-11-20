using System;
using System.Collections.Generic;

namespace ownWrld
{
    public class DictionaryService
    {
        public static void AddValuesToDictionary(Dictionary<string,string> dict)
        {
            string[] vals = Enum.GetNames(typeof(StripParameters));
            foreach (string val in vals)
            {
                dict[val] = LetterService.MakeMoreSenseOfTheNameFrom(val);
            }
        }
    }
}