using System.Collections.Generic;
using System.Web.Http;

namespace WebRole1.Controllers
{
	public class ChuckController : ApiController
	{
		private static List<ChuckFact> facts = new List<ChuckFact>()
		{
			new ChuckFact { Id = 1, Rating = 4, 
				Text = "Chuck Norris doesn't call the wrong number. You answer the wrong phone." },
			new ChuckFact { Id = 2, Rating = 3, 
				Text = "Chuck Norris counted to infinity. Twice." },
			new ChuckFact { Id = 3, Rating = 4, 
				Text = "When Alexander Bell invented the telephone he had 3 missed calls from Chuck Norris." },
		};


		public IEnumerable<ChuckFact> GetAllFacts()
		{
			return facts;
		}
	}

	public class ChuckFact
	{
		public int Id { get; set; }
		public string Text { get; set; }
		public int Rating { get; set; }
	}
}