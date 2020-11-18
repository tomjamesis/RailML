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
	public class TstopDescriptionsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TstopDescription> lTstopDescriptions = await db.TstopDescription.GetAllCompanyTstopDescriptions(id);
				 //return JsonConvert.SerializeObject(lTstopDescriptions.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TstopDescription tstopdescription)
			{
				 //Create
				 db.TstopDescription.Add(tstopdescription);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tstopdescription);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TstopDescription tstopdescription)
			{
				 //Update
				 db.TstopDescription.Update(tstopdescription);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TstopDescription tstopdescription)
			{
				 db.TstopDescription.Remove(tstopdescription);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
