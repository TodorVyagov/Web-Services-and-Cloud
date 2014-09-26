using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubstringCounterService
{
    public interface IStringCounterService
    {
        int CountSubstringsInString(string text, string phrase);
    }
}
