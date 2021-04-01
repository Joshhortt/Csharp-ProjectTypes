using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

// 2. Create a Model

namespace MvcMessageWall.Models
{
	public class MvcMessageModel
	{
		[Required]  // 7. Add Required and using CTRL + .  using..... DataAnnotations
		[StringLength(10, MinimumLength = 5)]  // 8.User Interface input limit
		[Display(Name = "Please insert a Really Cool Message")]  // 9.  User Interface display message
		public string Message { get; set; }  // 3. Add property
	}
}
