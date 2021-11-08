using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern
{
    class DefaultFormatter:IFormatter
    {
        public string Format(string text)
        {
            return text;
        }
    }
}
