using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern
{
    class DoubleCharacterFormatter: IFormatter
    {
        public string Format(string text)
        {
            var doubledChar = string.Empty;
            for (var i = 0; i <= text.Length - 1; i++)
            {
                doubledChar += text[i];
                doubledChar += text[i];
            }

            return doubledChar;
        }
    }
}
