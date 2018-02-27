using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace EnrollmentApplication.Models {
	public class Enrollment {
		public virtual int EnrollmentID { get; set; }
		public virtual int StudentID { get; set; }
		public virtual int CourseID { get; set; }
		[RegularExpression(@"[A-F]", ErrorMessage = "Grade must be A, B, C, D, or F.")]
		[Required(ErrorMessage = "Grade cannot be blank.")]
		public virtual string Grade { get; set; }
		public virtual Student Student { get; set; }
		public virtual Course Course { get; set; }
		public virtual bool IsActive { get; set; }
		[Display(Name = "Assigned Campus")]
		[Required(ErrorMessage = "Assigned Campus cannot be blank.")]
		public virtual string AssignedCampus { get; set; }
		[Display(Name = "Enrollment Semester")]
		[Required(ErrorMessage = "An Enrollment Semester must be selected.")]
		public virtual string EnrollmentSemester { get; set; }
		[Display(Name = "Enrollment Year")]
		[Range(2018, int.MaxValue, ErrorMessage = "Enrollment Year cannot be earlier than 2018.")]
		[Required(ErrorMessage = "Enrollment Year cannot be blank.")]
		public virtual int EnrollmentYear { get; set; }

	}
}