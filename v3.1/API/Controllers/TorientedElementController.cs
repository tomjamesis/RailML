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
	public class TorientedElementsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TorientedElement> lTorientedElements = await db.TorientedElement.GetAllCompanyTorientedElements(id);
				 //return JsonConvert.SerializeObject(lTorientedElements.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TorientedElement torientedelement)
			{
				 //Create
				 db.TorientedElement.Add(torientedelement);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(torientedelement);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TorientedElement torientedelement)
			{
				 //Update
				 db.TorientedElement.Update(torientedelement);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TorientedElement torientedelement)
			{
				 db.TorientedElement.Remove(torientedelement);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
