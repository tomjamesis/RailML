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
	public class TetcsTtsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TetcsTt> lTetcsTts = await db.TetcsTt.GetAllCompanyTetcsTts(id);
				 //return JsonConvert.SerializeObject(lTetcsTts.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TetcsTt tetcstt)
			{
				 //Create
				 db.TetcsTt.Add(tetcstt);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tetcstt);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TetcsTt tetcstt)
			{
				 //Update
				 db.TetcsTt.Update(tetcstt);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TetcsTt tetcstt)
			{
				 db.TetcsTt.Remove(tetcstt);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
