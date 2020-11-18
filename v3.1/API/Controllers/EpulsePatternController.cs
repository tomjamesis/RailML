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
	public class EpulsePatternsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<EpulsePattern> lEpulsePatterns = await db.EpulsePattern.GetAllCompanyEpulsePatterns(id);
				 //return JsonConvert.SerializeObject(lEpulsePatterns.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]EpulsePattern epulsepattern)
			{
				 //Create
				 db.EpulsePattern.Add(epulsepattern);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(epulsepattern);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]EpulsePattern epulsepattern)
			{
				 //Update
				 db.EpulsePattern.Update(epulsepattern);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]EpulsePattern epulsepattern)
			{
				 db.EpulsePattern.Remove(epulsepattern);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
