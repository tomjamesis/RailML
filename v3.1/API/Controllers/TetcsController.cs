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
	public class TetcssController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<Tetcs> lTetcss = await db.Tetcs.GetAllCompanyTetcss(id);
				 //return JsonConvert.SerializeObject(lTetcss.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]Tetcs tetcs)
			{
				 //Create
				 db.Tetcs.Add(tetcs);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tetcs);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]Tetcs tetcs)
			{
				 //Update
				 db.Tetcs.Update(tetcs);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]Tetcs tetcs)
			{
				 db.Tetcs.Remove(tetcs);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
