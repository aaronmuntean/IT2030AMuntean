using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EventApplication.Infrastructure {
	public class ValidDateAttribute : ValidationAttribute {

		protected override ValidationResult IsValid(object value, ValidationContext validationContext) {
			if(value != null) {
				string date = value as string;
				DateTime dt;
				bool isValid = false;
				if (DateTime.TryParse(date, out dt))
					 isValid = dt.Date > DateTime.Today;

				if (!isValid)
					return new ValidationResult("The date cannot be in the past.");
			}
			return ValidationResult.Success;
		}
	}
}