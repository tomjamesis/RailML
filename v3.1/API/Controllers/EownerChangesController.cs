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
	public class EownerChangessController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<EownerChanges> lEownerChangess = await db.EownerChanges.GetAllCompanyEownerChangess(id);
				 //return JsonConvert.SerializeObject(lEownerChangess.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]EownerChanges eownerchanges)
			{
				 //Create
				 db.EownerChanges.Add(eownerchanges);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(eownerchanges);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]EownerChanges eownerchanges)
			{
				 //Update
				 db.EownerChanges.Update(eownerchanges);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]EownerChanges eownerchanges)
			{
				 db.EownerChanges.Remove(eownerchanges);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
