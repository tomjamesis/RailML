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
	public class TdieselEnginesController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TdieselEngine> lTdieselEngines = await db.TdieselEngine.GetAllCompanyTdieselEngines(id);
				 //return JsonConvert.SerializeObject(lTdieselEngines.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TdieselEngine tdieselengine)
			{
				 //Create
				 db.TdieselEngine.Add(tdieselengine);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tdieselengine);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TdieselEngine tdieselengine)
			{
				 //Update
				 db.TdieselEngine.Update(tdieselengine);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TdieselEngine tdieselengine)
			{
				 db.TdieselEngine.Remove(tdieselengine);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
