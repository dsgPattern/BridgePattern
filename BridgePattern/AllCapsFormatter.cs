using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern
{
    class AllCapsFormatter: IFormatter
    {
        public string Format(string text)
        {
            return text.ToUpper();
        }
    }
}
