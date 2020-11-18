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
	public class TsignalLevelCrossingsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TsignalLevelCrossing> lTsignalLevelCrossings = await db.TsignalLevelCrossing.GetAllCompanyTsignalLevelCrossings(id);
				 //return JsonConvert.SerializeObject(lTsignalLevelCrossings.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TsignalLevelCrossing tsignallevelcrossing)
			{
				 //Create
				 db.TsignalLevelCrossing.Add(tsignallevelcrossing);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tsignallevelcrossing);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TsignalLevelCrossing tsignallevelcrossing)
			{
				 //Update
				 db.TsignalLevelCrossing.Update(tsignallevelcrossing);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TsignalLevelCrossing tsignallevelcrossing)
			{
				 db.TsignalLevelCrossing.Remove(tsignallevelcrossing);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
