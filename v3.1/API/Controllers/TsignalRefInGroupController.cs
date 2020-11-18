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
	public class TsignalRefInGroupsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TsignalRefInGroup> lTsignalRefInGroups = await db.TsignalRefInGroup.GetAllCompanyTsignalRefInGroups(id);
				 //return JsonConvert.SerializeObject(lTsignalRefInGroups.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TsignalRefInGroup tsignalrefingroup)
			{
				 //Create
				 db.TsignalRefInGroup.Add(tsignalrefingroup);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tsignalrefingroup);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TsignalRefInGroup tsignalrefingroup)
			{
				 //Update
				 db.TsignalRefInGroup.Update(tsignalrefingroup);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TsignalRefInGroup tsignalrefingroup)
			{
				 db.TsignalRefInGroup.Remove(tsignalrefingroup);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
