﻿using Microsoft.AspNetCore.Mvc;

namespace DrinkService.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class DrinkController : ControllerBase
	{
		private static readonly string[] Drinks = new[]
		{
			"Cola", "Water", "Tea", "Coffee", "Ginger Beer", "Orange Soda", "Lemonade"
		};

		private readonly ILogger<DrinkController> _logger;

		public DrinkController(ILogger<DrinkController> logger)
		{
			_logger = logger;
		}

		[HttpGet]
		public string Get()
		{
			var rng = new Random();
			var index = rng.Next(0, 6);
			return Drinks[index];
		}
	}
}
