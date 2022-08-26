using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WI_FI_Passwords
{
    public struct ParserResult
    {
        public string? ErrorMessage { get; init; }
        public string? SingleResult { get; init; }
        public IEnumerable<string>? MultipleResult { get; init; }
    }
}
