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
	public class EocpVissController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<EocpVis> lEocpViss = await db.EocpVis.GetAllCompanyEocpViss(id);
				 //return JsonConvert.SerializeObject(lEocpViss.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]EocpVis eocpvis)
			{
				 //Create
				 db.EocpVis.Add(eocpvis);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(eocpvis);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]EocpVis eocpvis)
			{
				 //Update
				 db.EocpVis.Update(eocpvis);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]EocpVis eocpvis)
			{
				 db.EocpVis.Remove(eocpvis);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
