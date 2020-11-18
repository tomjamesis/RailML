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
	public class TtrackCircuitBordersController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TtrackCircuitBorder> lTtrackCircuitBorders = await db.TtrackCircuitBorder.GetAllCompanyTtrackCircuitBorders(id);
				 //return JsonConvert.SerializeObject(lTtrackCircuitBorders.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TtrackCircuitBorder ttrackcircuitborder)
			{
				 //Create
				 db.TtrackCircuitBorder.Add(ttrackcircuitborder);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(ttrackcircuitborder);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TtrackCircuitBorder ttrackcircuitborder)
			{
				 //Update
				 db.TtrackCircuitBorder.Update(ttrackcircuitborder);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TtrackCircuitBorder ttrackcircuitborder)
			{
				 db.TtrackCircuitBorder.Remove(ttrackcircuitborder);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
