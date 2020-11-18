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
	public class TstrictOrientedElementsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TstrictOrientedElement> lTstrictOrientedElements = await db.TstrictOrientedElement.GetAllCompanyTstrictOrientedElements(id);
				 //return JsonConvert.SerializeObject(lTstrictOrientedElements.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TstrictOrientedElement tstrictorientedelement)
			{
				 //Create
				 db.TstrictOrientedElement.Add(tstrictorientedelement);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tstrictorientedelement);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TstrictOrientedElement tstrictorientedelement)
			{
				 //Update
				 db.TstrictOrientedElement.Update(tstrictorientedelement);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TstrictOrientedElement tstrictorientedelement)
			{
				 db.TstrictOrientedElement.Remove(tstrictorientedelement);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
