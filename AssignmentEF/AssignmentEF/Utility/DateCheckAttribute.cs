using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentEF.Utility
{
    internal class DateCheckAttribute : ValidationAttribute
    {
        private readonly DateTime _PoissuedDate;
        public DateCheckAttribute(DateTime PoIssuedDate) 
        {
            this._PoissuedDate = PoIssuedDate;
        }
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var date = (DateTime?)value;
            if (date.HasValue)
            {
                if (date <= _PoissuedDate)
                {
                    return new ValidationResult("Expiry date must be greater than the Issued date");
                }
            }
            return ValidationResult.Success;
        }
    }
}