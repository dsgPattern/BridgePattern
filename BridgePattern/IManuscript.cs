﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern
{
    public abstract class Manuscript
    {
        protected IFormatter _formatter;

        protected Manuscript(IFormatter formatter)
        {
            _formatter = formatter;
        }

        public abstract void Print();
    }
}
