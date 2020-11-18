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
	public class ElineVissController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<ElineVis> lElineViss = await db.ElineVis.GetAllCompanyElineViss(id);
				 //return JsonConvert.SerializeObject(lElineViss.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]ElineVis elinevis)
			{
				 //Create
				 db.ElineVis.Add(elinevis);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(elinevis);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]ElineVis elinevis)
			{
				 //Update
				 db.ElineVis.Update(elinevis);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]ElineVis elinevis)
			{
				 db.ElineVis.Remove(elinevis);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
