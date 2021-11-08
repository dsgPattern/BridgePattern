using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern
{
    public class MirrorFormater: IFormatter
    {
        public string Format(string text)
        {
            var mirrorText = string.Empty;
            for (var i = text.Length - 1; i >= 0; i--)
                mirrorText += text[i];

            return mirrorText;
        }
    }
}
