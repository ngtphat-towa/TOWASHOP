using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOWALibrary.Services.CommonServices
{
   public class ModelDataValidationCheck
    {
        public static void Validate(Object model)
        {
            StringBuilder errorMessage = new StringBuilder();
            List<ValidationResult> results = new List<ValidationResult>();
            ValidationContext context = new ValidationContext(model);
            bool isValid = Validator.TryValidateObject(model, context, results, true);
            if (!isValid)
            {
                foreach (var error in results)
                    errorMessage.AppendLine($"- { error.ErrorMessage} ");
                throw new Exception(errorMessage.ToString());
            }
        }
    }
}
