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
	public class TplatformEdgesController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TplatformEdge> lTplatformEdges = await db.TplatformEdge.GetAllCompanyTplatformEdges(id);
				 //return JsonConvert.SerializeObject(lTplatformEdges.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TplatformEdge tplatformedge)
			{
				 //Create
				 db.TplatformEdge.Add(tplatformedge);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tplatformedge);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TplatformEdge tplatformedge)
			{
				 //Update
				 db.TplatformEdge.Update(tplatformedge);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TplatformEdge tplatformedge)
			{
				 db.TplatformEdge.Remove(tplatformedge);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
