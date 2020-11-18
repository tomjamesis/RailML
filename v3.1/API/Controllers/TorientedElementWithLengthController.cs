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
	public class TorientedElementWithLengthsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TorientedElementWithLength> lTorientedElementWithLengths = await db.TorientedElementWithLength.GetAllCompanyTorientedElementWithLengths(id);
				 //return JsonConvert.SerializeObject(lTorientedElementWithLengths.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TorientedElementWithLength torientedelementwithlength)
			{
				 //Create
				 db.TorientedElementWithLength.Add(torientedelementwithlength);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(torientedelementwithlength);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TorientedElementWithLength torientedelementwithlength)
			{
				 //Update
				 db.TorientedElementWithLength.Update(torientedelementwithlength);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TorientedElementWithLength torientedelementwithlength)
			{
				 db.TorientedElementWithLength.Remove(torientedelementwithlength);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
