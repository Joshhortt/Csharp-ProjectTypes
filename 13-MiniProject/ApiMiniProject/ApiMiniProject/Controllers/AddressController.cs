using ApiMiniProject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiMiniProject.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class AddressController : ControllerBase
	{
		private ILogger _logger;
		public AddressController(ILogger<AddressController> logger)
		{
			_logger = logger;
		}

		// POST api/<AddressController>
		[HttpPost]
		public void Post([FromBody] AddressModel data)
		{
			_logger.LogInformation("The person was logged as {Address}", data);
		}
	}
}
