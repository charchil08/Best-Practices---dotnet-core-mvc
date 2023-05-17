using System;
using System.Collections.Generic;
using System.Linq;

namespace ValidationDemo.Utility.CustomExceptions
{
    public class InvalidModelStateException : Exception
    {
        public IDictionary<string, string> Errors { get; } = new Dictionary<string, string>();

        public InvalidModelStateException(Dictionary<string, string> errors)
        {
            Errors = errors;
        }
    }
}
