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
	public class TstrictOrientedElementWithLengthsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TstrictOrientedElementWithLength> lTstrictOrientedElementWithLengths = await db.TstrictOrientedElementWithLength.GetAllCompanyTstrictOrientedElementWithLengths(id);
				 //return JsonConvert.SerializeObject(lTstrictOrientedElementWithLengths.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TstrictOrientedElementWithLength tstrictorientedelementwithlength)
			{
				 //Create
				 db.TstrictOrientedElementWithLength.Add(tstrictorientedelementwithlength);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tstrictorientedelementwithlength);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TstrictOrientedElementWithLength tstrictorientedelementwithlength)
			{
				 //Update
				 db.TstrictOrientedElementWithLength.Update(tstrictorientedelementwithlength);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TstrictOrientedElementWithLength tstrictorientedelementwithlength)
			{
				 db.TstrictOrientedElementWithLength.Remove(tstrictorientedelementwithlength);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
