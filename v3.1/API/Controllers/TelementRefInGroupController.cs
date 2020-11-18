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
	public class TelementRefInGroupsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TelementRefInGroup> lTelementRefInGroups = await db.TelementRefInGroup.GetAllCompanyTelementRefInGroups(id);
				 //return JsonConvert.SerializeObject(lTelementRefInGroups.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TelementRefInGroup telementrefingroup)
			{
				 //Create
				 db.TelementRefInGroup.Add(telementrefingroup);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(telementrefingroup);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TelementRefInGroup telementrefingroup)
			{
				 //Update
				 db.TelementRefInGroup.Update(telementrefingroup);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TelementRefInGroup telementrefingroup)
			{
				 db.TelementRefInGroup.Remove(telementrefingroup);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
