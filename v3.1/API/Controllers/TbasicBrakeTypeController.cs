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
	public class TbasicBrakeTypesController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TbasicBrakeType> lTbasicBrakeTypes = await db.TbasicBrakeType.GetAllCompanyTbasicBrakeTypes(id);
				 //return JsonConvert.SerializeObject(lTbasicBrakeTypes.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TbasicBrakeType tbasicbraketype)
			{
				 //Create
				 db.TbasicBrakeType.Add(tbasicbraketype);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tbasicbraketype);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TbasicBrakeType tbasicbraketype)
			{
				 //Update
				 db.TbasicBrakeType.Update(tbasicbraketype);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TbasicBrakeType tbasicbraketype)
			{
				 db.TbasicBrakeType.Remove(tbasicbraketype);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
