using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xUnitFixturesLifeCycle
{
    static class Out
    {
        public static void Show(this string text)
        {
            Debug.WriteLine(text);
        }
    }
}
