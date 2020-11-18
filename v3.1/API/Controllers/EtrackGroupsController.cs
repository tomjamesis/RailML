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
	public class EtrackGroupssController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<EtrackGroups> lEtrackGroupss = await db.EtrackGroups.GetAllCompanyEtrackGroupss(id);
				 //return JsonConvert.SerializeObject(lEtrackGroupss.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]EtrackGroups etrackgroups)
			{
				 //Create
				 db.EtrackGroups.Add(etrackgroups);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(etrackgroups);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]EtrackGroups etrackgroups)
			{
				 //Update
				 db.EtrackGroups.Update(etrackgroups);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]EtrackGroups etrackgroups)
			{
				 db.EtrackGroups.Remove(etrackgroups);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
