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
	public class EtrackVissController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<EtrackVis> lEtrackViss = await db.EtrackVis.GetAllCompanyEtrackViss(id);
				 //return JsonConvert.SerializeObject(lEtrackViss.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]EtrackVis etrackvis)
			{
				 //Create
				 db.EtrackVis.Add(etrackvis);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(etrackvis);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]EtrackVis etrackvis)
			{
				 //Update
				 db.EtrackVis.Update(etrackvis);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]EtrackVis etrackvis)
			{
				 db.EtrackVis.Remove(etrackvis);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
