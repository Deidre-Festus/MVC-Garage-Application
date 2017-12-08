using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Web;

namespace MVC_GarageApp.Utility
{
    /// <summary>
    /// A class that's hold some extra validation methods
    /// </summary>
    public class MaxWordsAttribute : ValidationAttribute
    {
        public MaxWordsAttribute(int maxWords) : base("{0} has too many words.")
        {
            _maxWords = maxWords;
        }

        protected override ValidationResult IsValid(
            object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                var valueAsString = value.ToString();
                if (valueAsString.Split(' ').Length > _maxWords)
                {
                    var errorMessage = FormatErrorMessage(validationContext.DisplayName);
                }
            }
            return ValidationResult.Success;
        }
        private readonly int _maxWords;
    }
}