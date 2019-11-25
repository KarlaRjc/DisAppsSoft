using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoDeActivos.Controller.Sanitize
{
    public class NumericInput : Sanitizer
    {
        public override Dictionary<EnumSanitizeErrors, string> SanitizeInput(string input)
        {
            var result = new Dictionary<EnumSanitizeErrors, string>();
            if (input == null)
            {
                result.Add(EnumSanitizeErrors.NullNotAllowed, "Input cannot be empty");
            }
            if (!int.TryParse(input, out int intOutput)) 
            {
                result.Add(EnumSanitizeErrors.Not_A_Number, "Input must be a number");
            }
            return result;
        }
    }
}