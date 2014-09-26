using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubstringCounterService
{
    public class StringCounterService : IStringCounterService
    {
        public int CountSubstringsInString(string text, string phrase)
        {
            int index = text.IndexOf(phrase);
            int counter = 0;

            while (index >= 0)
            {
                counter++;
                index = text.IndexOf(phrase, index);
            }

            return counter;
        }
    }
}
