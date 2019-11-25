using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoDeActivos.Controller.Sanitize
{
    public abstract class Sanitizer
    {
        public abstract Dictionary<EnumSanitizeErrors, String> SanitizeInput(String input);
    }
}
