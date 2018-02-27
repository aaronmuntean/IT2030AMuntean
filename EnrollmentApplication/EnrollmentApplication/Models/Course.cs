using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EnrollmentApplication.Models {
	public class Course {
		[Display(Name = "Course ID")]
		public virtual int CourseID { get; set; }
		[Display(Name = "Course Title")]
		[Required(ErrorMessage = "Course Title cannot be blank.")]
		[MaxLength(150, ErrorMessage = "Course Title must be 1-150 characters.")]
		public virtual string Title { get; set; }
		[Display(Name = "Description")]
		[Required(ErrorMessage = "Description cannot be blank.")]
		public virtual string Description { get; set; }
		[Display(Name = "Number of Credits")]
		[Range(1, 4, ErrorMessage = "Number of Credits must be a value 1-4.")]
		[Required(ErrorMessage = "Number of Credits cannot be blank.")]
		public virtual int Credits { get; set; }
	}
}