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
	public class TtrainGroupsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TtrainGroup> lTtrainGroups = await db.TtrainGroup.GetAllCompanyTtrainGroups(id);
				 //return JsonConvert.SerializeObject(lTtrainGroups.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TtrainGroup ttraingroup)
			{
				 //Create
				 db.TtrainGroup.Add(ttraingroup);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(ttraingroup);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TtrainGroup ttraingroup)
			{
				 //Update
				 db.TtrainGroup.Update(ttraingroup);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TtrainGroup ttraingroup)
			{
				 db.TtrainGroup.Remove(ttraingroup);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
