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
	public class TtimeSpansController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TtimeSpan> lTtimeSpans = await db.TtimeSpan.GetAllCompanyTtimeSpans(id);
				 //return JsonConvert.SerializeObject(lTtimeSpans.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TtimeSpan ttimespan)
			{
				 //Create
				 db.TtimeSpan.Add(ttimespan);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(ttimespan);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TtimeSpan ttimespan)
			{
				 //Update
				 db.TtimeSpan.Update(ttimespan);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TtimeSpan ttimespan)
			{
				 db.TtimeSpan.Remove(ttimespan);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
