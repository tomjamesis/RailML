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
	public class ToperationModeChangesController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<ToperationModeChange> lToperationModeChanges = await db.ToperationModeChange.GetAllCompanyToperationModeChanges(id);
				 //return JsonConvert.SerializeObject(lToperationModeChanges.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]ToperationModeChange toperationmodechange)
			{
				 //Create
				 db.ToperationModeChange.Add(toperationmodechange);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(toperationmodechange);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]ToperationModeChange toperationmodechange)
			{
				 //Update
				 db.ToperationModeChange.Update(toperationmodechange);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]ToperationModeChange toperationmodechange)
			{
				 db.ToperationModeChange.Remove(toperationmodechange);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
