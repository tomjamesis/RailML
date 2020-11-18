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
	public class TinsulatedRailSidesController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TinsulatedRailSide> lTinsulatedRailSides = await db.TinsulatedRailSide.GetAllCompanyTinsulatedRailSides(id);
				 //return JsonConvert.SerializeObject(lTinsulatedRailSides.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TinsulatedRailSide tinsulatedrailside)
			{
				 //Create
				 db.TinsulatedRailSide.Add(tinsulatedrailside);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tinsulatedrailside);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TinsulatedRailSide tinsulatedrailside)
			{
				 //Update
				 db.TinsulatedRailSide.Update(tinsulatedrailside);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TinsulatedRailSide tinsulatedrailside)
			{
				 db.TinsulatedRailSide.Remove(tinsulatedrailside);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
