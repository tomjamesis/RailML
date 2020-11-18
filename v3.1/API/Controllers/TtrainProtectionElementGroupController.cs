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
	public class TtrainProtectionElementGroupsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TtrainProtectionElementGroup> lTtrainProtectionElementGroups = await db.TtrainProtectionElementGroup.GetAllCompanyTtrainProtectionElementGroups(id);
				 //return JsonConvert.SerializeObject(lTtrainProtectionElementGroups.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TtrainProtectionElementGroup ttrainprotectionelementgroup)
			{
				 //Create
				 db.TtrainProtectionElementGroup.Add(ttrainprotectionelementgroup);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(ttrainprotectionelementgroup);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TtrainProtectionElementGroup ttrainprotectionelementgroup)
			{
				 //Update
				 db.TtrainProtectionElementGroup.Update(ttrainprotectionelementgroup);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TtrainProtectionElementGroup ttrainprotectionelementgroup)
			{
				 db.TtrainProtectionElementGroup.Remove(ttrainprotectionelementgroup);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
