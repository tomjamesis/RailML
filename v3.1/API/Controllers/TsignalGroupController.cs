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
	public class TsignalGroupsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TsignalGroup> lTsignalGroups = await db.TsignalGroup.GetAllCompanyTsignalGroups(id);
				 //return JsonConvert.SerializeObject(lTsignalGroups.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TsignalGroup tsignalgroup)
			{
				 //Create
				 db.TsignalGroup.Add(tsignalgroup);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tsignalgroup);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TsignalGroup tsignalgroup)
			{
				 //Update
				 db.TsignalGroup.Update(tsignalgroup);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TsignalGroup tsignalgroup)
			{
				 db.TsignalGroup.Remove(tsignalgroup);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
