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
	public class TplatformEdgeRefsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TplatformEdgeRef> lTplatformEdgeRefs = await db.TplatformEdgeRef.GetAllCompanyTplatformEdgeRefs(id);
				 //return JsonConvert.SerializeObject(lTplatformEdgeRefs.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TplatformEdgeRef tplatformedgeref)
			{
				 //Create
				 db.TplatformEdgeRef.Add(tplatformedgeref);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tplatformedgeref);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TplatformEdgeRef tplatformedgeref)
			{
				 //Update
				 db.TplatformEdgeRef.Update(tplatformedgeref);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TplatformEdgeRef tplatformedgeref)
			{
				 db.TplatformEdgeRef.Remove(tplatformedgeref);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
