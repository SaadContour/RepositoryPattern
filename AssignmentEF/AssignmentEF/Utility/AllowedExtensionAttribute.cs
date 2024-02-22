using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentEF.Utility
{
    internal class AllowedExtensionAttribute : ValidationAttribute
    {
        private readonly string[] _allowedExtension;
        public AllowedExtensionAttribute(string[] extensions) 
        {
            _allowedExtension = extensions;
        }
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            string? path = value as string;
            if (value != null)
            {
                string? extension = Path.GetExtension(path);
                
                if (extension != null)
                {
                    if (!_allowedExtension.Contains(extension))
                    {
                        return new ValidationResult($"This photo extension is not allowed! use {_allowedExtension}");
                    }
                }
            }
            return ValidationResult.Success;
        }
    }
}
