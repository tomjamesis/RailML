using Models.DB;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Controllers
{
	[Route("api/[controller]")]
	//[Authorize]
	[ApiController]
	public class EreplacedTrainssController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<EreplacedTrains> lEreplacedTrainss = await db.EreplacedTrains.GetAllCompanyEreplacedTrainss(id);
				 //return JsonConvert.SerializeObject(lEreplacedTrainss.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]EreplacedTrains ereplacedtrains)
			{
				 //Create
				 db.EreplacedTrains.Add(ereplacedtrains);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(ereplacedtrains);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]EreplacedTrains ereplacedtrains)
			{
				 //Update
				 db.EreplacedTrains.Update(ereplacedtrains);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]EreplacedTrains ereplacedtrains)
			{
				 db.EreplacedTrains.Remove(ereplacedtrains);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
