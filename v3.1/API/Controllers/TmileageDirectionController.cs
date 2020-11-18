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
	public class TmileageDirectionsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TmileageDirection> lTmileageDirections = await db.TmileageDirection.GetAllCompanyTmileageDirections(id);
				 //return JsonConvert.SerializeObject(lTmileageDirections.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TmileageDirection tmileagedirection)
			{
				 //Create
				 db.TmileageDirection.Add(tmileagedirection);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tmileagedirection);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TmileageDirection tmileagedirection)
			{
				 //Update
				 db.TmileageDirection.Update(tmileagedirection);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TmileageDirection tmileagedirection)
			{
				 db.TmileageDirection.Remove(tmileagedirection);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
