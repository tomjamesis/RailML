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
	public class EplatformEdgessController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<EplatformEdges> lEplatformEdgess = await db.EplatformEdges.GetAllCompanyEplatformEdgess(id);
				 //return JsonConvert.SerializeObject(lEplatformEdgess.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]EplatformEdges eplatformedges)
			{
				 //Create
				 db.EplatformEdges.Add(eplatformedges);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(eplatformedges);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]EplatformEdges eplatformedges)
			{
				 //Update
				 db.EplatformEdges.Update(eplatformedges);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]EplatformEdges eplatformedges)
			{
				 db.EplatformEdges.Remove(eplatformedges);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
