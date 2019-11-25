using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoDeActivos.Controller.Sanitize
{
    public class CharInput : Sanitizer
    {
        public override Dictionary<EnumSanitizeErrors, string> SanitizeInput(string input)
        {
            var result = new Dictionary<EnumSanitizeErrors, string>();
            if (input == "") 
            {
                result.Add(EnumSanitizeErrors.NullNotAllowed, "Input cannot be empty");
            }
            return result;
        }
    }
}
