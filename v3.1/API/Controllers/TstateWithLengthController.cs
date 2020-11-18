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
	public class TstateWithLengthsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TstateWithLength> lTstateWithLengths = await db.TstateWithLength.GetAllCompanyTstateWithLengths(id);
				 //return JsonConvert.SerializeObject(lTstateWithLengths.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TstateWithLength tstatewithlength)
			{
				 //Create
				 db.TstateWithLength.Add(tstatewithlength);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tstatewithlength);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TstateWithLength tstatewithlength)
			{
				 //Update
				 db.TstateWithLength.Update(tstatewithlength);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TstateWithLength tstatewithlength)
			{
				 db.TstateWithLength.Remove(tstatewithlength);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
