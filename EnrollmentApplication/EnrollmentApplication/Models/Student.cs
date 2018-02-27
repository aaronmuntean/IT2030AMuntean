using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EnrollmentApplication.Models {
	public class Student {
		[Display(Name = "Student ID")]
		public virtual int StudentID { get; set; }
		[Display(Name = "Last Name")]
		[Required (ErrorMessage = "Last Name cannot be blank.")]
		[MaxLength(50, ErrorMessage = "Last Name must be 1-50 characters.")]
		public virtual string LastName { get; set; }
		[Display(Name = "First Name")]
		[Required(ErrorMessage = "First Name cannot be blank.")]
		[MaxLength(50, ErrorMessage = "First Name must be 1-50 characters.")]
		public virtual string FirstName { get; set; }

	}
}