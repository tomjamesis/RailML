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
	public class EoperationModeChangessController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<EoperationModeChanges> lEoperationModeChangess = await db.EoperationModeChanges.GetAllCompanyEoperationModeChangess(id);
				 //return JsonConvert.SerializeObject(lEoperationModeChangess.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]EoperationModeChanges eoperationmodechanges)
			{
				 //Create
				 db.EoperationModeChanges.Add(eoperationmodechanges);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(eoperationmodechanges);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]EoperationModeChanges eoperationmodechanges)
			{
				 //Update
				 db.EoperationModeChanges.Update(eoperationmodechanges);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]EoperationModeChanges eoperationmodechanges)
			{
				 db.EoperationModeChanges.Remove(eoperationmodechanges);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
