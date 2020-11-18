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
	public class ElevelCrossingsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<ElevelCrossing> lElevelCrossings = await db.ElevelCrossing.GetAllCompanyElevelCrossings(id);
				 //return JsonConvert.SerializeObject(lElevelCrossings.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]ElevelCrossing elevelcrossing)
			{
				 //Create
				 db.ElevelCrossing.Add(elevelcrossing);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(elevelcrossing);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]ElevelCrossing elevelcrossing)
			{
				 //Update
				 db.ElevelCrossing.Update(elevelcrossing);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]ElevelCrossing elevelcrossing)
			{
				 db.ElevelCrossing.Remove(elevelcrossing);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
