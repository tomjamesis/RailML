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
	public class ToperationalUndertakingsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<ToperationalUndertaking> lToperationalUndertakings = await db.ToperationalUndertaking.GetAllCompanyToperationalUndertakings(id);
				 //return JsonConvert.SerializeObject(lToperationalUndertakings.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]ToperationalUndertaking toperationalundertaking)
			{
				 //Create
				 db.ToperationalUndertaking.Add(toperationalundertaking);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(toperationalundertaking);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]ToperationalUndertaking toperationalundertaking)
			{
				 //Update
				 db.ToperationalUndertaking.Update(toperationalundertaking);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]ToperationalUndertaking toperationalundertaking)
			{
				 db.ToperationalUndertaking.Remove(toperationalundertaking);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
