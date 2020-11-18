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
	public class TtrackRefsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TtrackRef> lTtrackRefs = await db.TtrackRef.GetAllCompanyTtrackRefs(id);
				 //return JsonConvert.SerializeObject(lTtrackRefs.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TtrackRef ttrackref)
			{
				 //Create
				 db.TtrackRef.Add(ttrackref);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(ttrackref);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TtrackRef ttrackref)
			{
				 //Update
				 db.TtrackRef.Update(ttrackref);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TtrackRef ttrackref)
			{
				 db.TtrackRef.Remove(ttrackref);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
