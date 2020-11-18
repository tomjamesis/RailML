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
	public class TlevelCrossingsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TlevelCrossing> lTlevelCrossings = await db.TlevelCrossing.GetAllCompanyTlevelCrossings(id);
				 //return JsonConvert.SerializeObject(lTlevelCrossings.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TlevelCrossing tlevelcrossing)
			{
				 //Create
				 db.TlevelCrossing.Add(tlevelcrossing);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tlevelcrossing);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TlevelCrossing tlevelcrossing)
			{
				 //Update
				 db.TlevelCrossing.Update(tlevelcrossing);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TlevelCrossing tlevelcrossing)
			{
				 db.TlevelCrossing.Remove(tlevelcrossing);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
