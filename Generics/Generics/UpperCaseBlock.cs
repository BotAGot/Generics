﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class UpperCaseBlock : IBlock<string>
    {
        public string Process(string input)
        {
            return input.ToUpper();
        }
    }
}
