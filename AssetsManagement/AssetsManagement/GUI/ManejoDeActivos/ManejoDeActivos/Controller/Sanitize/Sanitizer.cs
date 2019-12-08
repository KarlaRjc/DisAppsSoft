using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManejoDeActivos.Controller.Sanitize
{
    public abstract class Sanitizer
    {
        public static bool Sanitize(Label errorMessageLabel, Sanitizer sanitizer, string input)
        {
            errorMessageLabel.ResetText();
            bool isInputValid = false;
            var inputErrors = sanitizer.SanitizeInput(input);
            if (inputErrors.Count == 0)
            {
                isInputValid = true;
            } else 
            {
                if (inputErrors.Count == 1)
                {
                    errorMessageLabel.Text = inputErrors.FirstOrDefault().Value;
                } else 
                {
                    foreach (KeyValuePair<EnumSanitizeErrors, string> entry in inputErrors)
                    {
                        errorMessageLabel.Text += (entry.Value + ", ");
                    }
                }
            }
            return isInputValid;
        }
        public abstract Dictionary<EnumSanitizeErrors, String> SanitizeInput(String input);
    }
}
