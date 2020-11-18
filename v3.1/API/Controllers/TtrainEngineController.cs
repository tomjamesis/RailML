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
	public class TtrainEnginesController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TtrainEngine> lTtrainEngines = await db.TtrainEngine.GetAllCompanyTtrainEngines(id);
				 //return JsonConvert.SerializeObject(lTtrainEngines.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TtrainEngine ttrainengine)
			{
				 //Create
				 db.TtrainEngine.Add(ttrainengine);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(ttrainengine);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TtrainEngine ttrainengine)
			{
				 //Update
				 db.TtrainEngine.Update(ttrainengine);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TtrainEngine ttrainengine)
			{
				 db.TtrainEngine.Remove(ttrainengine);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
