using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoDeActivos.Controller.Sanitize.DefinedSanitizers
{
    class GeneralInputSanitizer : Sanitizer
    {
        public override Dictionary<EnumSanitizeErrors, string> SanitizeInput(string input)
        {
            return new CharInput().SanitizeInput(input);
        }
    }
}