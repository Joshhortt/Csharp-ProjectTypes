using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MessageWallApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class MessageWallController : ControllerBase
	{
		private ILogger _logger;

		public MessageWallController(ILogger<MessageWallController> logger)
		{
			_logger = logger;
		}

		// GET: api/<MessageWallController>
		[HttpGet]

		public IEnumerable<string> Get(string message = "")
		{
			List<string> output = new List<string>  // 3. Add new Instance
			{
				// 4. Add two strings
				"Hello Api",
				"How are you?"
			};

			// 5. Add condition if string is null or empty false
			if(string.IsNullOrWhiteSpace(message) == false)
			{
				output.Add(message); // 6. add message to output
			}

			return output;  // 7. return output
		}

		// GET api/<MessageWallController>/5
		[HttpGet("{id}")]
		public string Get(int id)
		{
			return "value";
		}

		// POST api/<MessageWallController>
		[HttpPost]
		public void Post([FromBody] string value)
		{
		}

		// PUT api/<MessageWallController>/5
		[HttpPut("{id}")]
		public void Put(int id, [FromBody] string value)
		{
		}

		// DELETE api/<MessageWallController>/5
		[HttpDelete("{id}")]
		public void Delete(int id)
		{
		}
	}
}
