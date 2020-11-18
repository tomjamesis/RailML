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
	public class TpointsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<Tpoint> lTpoints = await db.Tpoint.GetAllCompanyTpoints(id);
				 //return JsonConvert.SerializeObject(lTpoints.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]Tpoint tpoint)
			{
				 //Create
				 db.Tpoint.Add(tpoint);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tpoint);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]Tpoint tpoint)
			{
				 //Update
				 db.Tpoint.Update(tpoint);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]Tpoint tpoint)
			{
				 db.Tpoint.Remove(tpoint);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
