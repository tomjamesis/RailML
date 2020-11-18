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
	public class TbufferStopsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TbufferStop> lTbufferStops = await db.TbufferStop.GetAllCompanyTbufferStops(id);
				 //return JsonConvert.SerializeObject(lTbufferStops.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TbufferStop tbufferstop)
			{
				 //Create
				 db.TbufferStop.Add(tbufferstop);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tbufferstop);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TbufferStop tbufferstop)
			{
				 //Update
				 db.TbufferStop.Update(tbufferstop);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TbufferStop tbufferstop)
			{
				 db.TbufferStop.Remove(tbufferstop);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
