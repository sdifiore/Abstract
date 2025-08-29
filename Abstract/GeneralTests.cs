using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;

namespace Abstract
{
	internal class GeneralTests
	{
		private readonly ILogger<Test> _logger;

		public GeneralTests(ILogger<Test> logger)
		{
			_logger = logger ?? throw new ArgumentNullException(nameof(logger));
		}
	}

	internal class Test
	{
		public Test(ILogger<Test> logger)
		{
		}

		internal void Run()
		{
			throw new NotImplementedException();
		}
	}
}
