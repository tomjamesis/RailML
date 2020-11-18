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
	public class TplacedElementWithLengthsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TplacedElementWithLength> lTplacedElementWithLengths = await db.TplacedElementWithLength.GetAllCompanyTplacedElementWithLengths(id);
				 //return JsonConvert.SerializeObject(lTplacedElementWithLengths.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TplacedElementWithLength tplacedelementwithlength)
			{
				 //Create
				 db.TplacedElementWithLength.Add(tplacedelementwithlength);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tplacedelementwithlength);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TplacedElementWithLength tplacedelementwithlength)
			{
				 //Update
				 db.TplacedElementWithLength.Update(tplacedelementwithlength);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TplacedElementWithLength tplacedelementwithlength)
			{
				 db.TplacedElementWithLength.Remove(tplacedelementwithlength);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
