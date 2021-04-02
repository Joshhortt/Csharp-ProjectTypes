using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MessageWallApi.Models
{
	// 11. Create Model Diretctory and add this class.
	public class MessageModel
	{
		// 12. Add properties with Id message identifier.
		public int Id { get; set; }
		public string Message { get; set; }
	}
}
