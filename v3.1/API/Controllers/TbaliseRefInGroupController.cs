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
	public class TbaliseRefInGroupsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TbaliseRefInGroup> lTbaliseRefInGroups = await db.TbaliseRefInGroup.GetAllCompanyTbaliseRefInGroups(id);
				 //return JsonConvert.SerializeObject(lTbaliseRefInGroups.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TbaliseRefInGroup tbaliserefingroup)
			{
				 //Create
				 db.TbaliseRefInGroup.Add(tbaliserefingroup);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tbaliserefingroup);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TbaliseRefInGroup tbaliserefingroup)
			{
				 //Update
				 db.TbaliseRefInGroup.Update(tbaliserefingroup);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TbaliseRefInGroup tbaliserefingroup)
			{
				 db.TbaliseRefInGroup.Remove(tbaliserefingroup);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
