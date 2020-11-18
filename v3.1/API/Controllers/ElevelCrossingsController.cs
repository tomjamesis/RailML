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
	public class ElevelCrossingssController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<ElevelCrossings> lElevelCrossingss = await db.ElevelCrossings.GetAllCompanyElevelCrossingss(id);
				 //return JsonConvert.SerializeObject(lElevelCrossingss.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]ElevelCrossings elevelcrossings)
			{
				 //Create
				 db.ElevelCrossings.Add(elevelcrossings);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(elevelcrossings);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]ElevelCrossings elevelcrossings)
			{
				 //Update
				 db.ElevelCrossings.Update(elevelcrossings);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]ElevelCrossings elevelcrossings)
			{
				 db.ElevelCrossings.Remove(elevelcrossings);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
