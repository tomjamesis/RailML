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
	public class TbaliseGroupsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TbaliseGroup> lTbaliseGroups = await db.TbaliseGroup.GetAllCompanyTbaliseGroups(id);
				 //return JsonConvert.SerializeObject(lTbaliseGroups.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TbaliseGroup tbalisegroup)
			{
				 //Create
				 db.TbaliseGroup.Add(tbalisegroup);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tbalisegroup);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TbaliseGroup tbalisegroup)
			{
				 //Update
				 db.TbaliseGroup.Update(tbalisegroup);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TbaliseGroup tbalisegroup)
			{
				 db.TbaliseGroup.Remove(tbalisegroup);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
