using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ManejoDeActivos.Controller.Sanitize
{
    class SpecialCharsNotAllowed : SanitizerDecorator
    {
        Sanitizer sanitizer;

        public SpecialCharsNotAllowed(Sanitizer sanitizer) 
        {
            this.sanitizer = sanitizer;
        }
        public override Dictionary<EnumSanitizeErrors, string> SanitizeInput(string input)
        {
            var result = new Dictionary<EnumSanitizeErrors, string>();
            var regexItem = new Regex("^[a-zA-Z0-9 ]*$");
            if (!regexItem.IsMatch(input))
            {
                result.Add(EnumSanitizeErrors.SpecialCharsNotAllowed,"Special characters are not allowed");
            }
            foreach (var sanitizer in sanitizer.SanitizeInput(input))
                result.Add(sanitizer.Key, sanitizer.Value);
            return result;
        }
    }
}
