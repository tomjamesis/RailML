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
	public class EtrackEndsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<EtrackEnd> lEtrackEnds = await db.EtrackEnd.GetAllCompanyEtrackEnds(id);
				 //return JsonConvert.SerializeObject(lEtrackEnds.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]EtrackEnd etrackend)
			{
				 //Create
				 db.EtrackEnd.Add(etrackend);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(etrackend);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]EtrackEnd etrackend)
			{
				 //Update
				 db.EtrackEnd.Update(etrackend);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]EtrackEnd etrackend)
			{
				 db.EtrackEnd.Remove(etrackend);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
