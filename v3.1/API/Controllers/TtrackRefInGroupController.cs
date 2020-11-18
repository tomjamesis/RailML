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
	public class TtrackRefInGroupsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TtrackRefInGroup> lTtrackRefInGroups = await db.TtrackRefInGroup.GetAllCompanyTtrackRefInGroups(id);
				 //return JsonConvert.SerializeObject(lTtrackRefInGroups.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TtrackRefInGroup ttrackrefingroup)
			{
				 //Create
				 db.TtrackRefInGroup.Add(ttrackrefingroup);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(ttrackrefingroup);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TtrackRefInGroup ttrackrefingroup)
			{
				 //Update
				 db.TtrackRefInGroup.Update(ttrackrefingroup);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TtrackRefInGroup ttrackrefingroup)
			{
				 db.TtrackRefInGroup.Remove(ttrackrefingroup);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
