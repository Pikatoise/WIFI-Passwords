﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WI_FI_Passwords
{
    public struct ParserResult
    {
        public string ErrorMessage { get; }
        public string SingleResult { get; }
        public IEnumerable<string> MultipleResult { get; }
    }
}