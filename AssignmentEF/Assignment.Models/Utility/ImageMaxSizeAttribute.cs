using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Models.Utility
{
    internal class ImageMaxSizeAttribute : ValidationAttribute
    {
        private readonly int _imageMaxSize;
        public ImageMaxSizeAttribute(int imageMaxSize)
        {
            this._imageMaxSize = imageMaxSize;
        }

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value != null)
            {
                string? path = value as String;
                if(path != null)
                {
                    FileInfo fileInfo = new FileInfo(path);
                    if (fileInfo.Length > 1000000 * _imageMaxSize)
                    {
                        return new ValidationResult($"Maximum file size allowed is {_imageMaxSize}MB");
                    }
                    
                }
            }
            return ValidationResult.Success;

            return base.IsValid(value, validationContext);
        }
    }
}
