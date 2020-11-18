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
	public class TplacedElementsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TplacedElement> lTplacedElements = await db.TplacedElement.GetAllCompanyTplacedElements(id);
				 //return JsonConvert.SerializeObject(lTplacedElements.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TplacedElement tplacedelement)
			{
				 //Create
				 db.TplacedElement.Add(tplacedelement);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tplacedelement);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TplacedElement tplacedelement)
			{
				 //Update
				 db.TplacedElement.Update(tplacedelement);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TplacedElement tplacedelement)
			{
				 db.TplacedElement.Remove(tplacedelement);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
