using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMiniProject.Models
{
	public class PersonModel
	{
		[Required]
		[Display(Name = "First Name")]
		public int FirstName { get; set; }

		[Required]
		[Display(Name = "Last Name")]
		public int LastName { get; set; }

		[Display(Name = "Active User")]
		public bool IsActive { get; set; }
	}
}
