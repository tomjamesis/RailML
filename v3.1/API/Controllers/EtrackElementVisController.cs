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
	public class EtrackElementVissController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<EtrackElementVis> lEtrackElementViss = await db.EtrackElementVis.GetAllCompanyEtrackElementViss(id);
				 //return JsonConvert.SerializeObject(lEtrackElementViss.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]EtrackElementVis etrackelementvis)
			{
				 //Create
				 db.EtrackElementVis.Add(etrackelementvis);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(etrackelementvis);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]EtrackElementVis etrackelementvis)
			{
				 //Update
				 db.EtrackElementVis.Update(etrackelementvis);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]EtrackElementVis etrackelementvis)
			{
				 db.EtrackElementVis.Remove(etrackelementvis);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
