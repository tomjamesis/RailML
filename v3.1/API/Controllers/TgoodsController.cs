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
	public class TgoodssController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<Tgoods> lTgoodss = await db.Tgoods.GetAllCompanyTgoodss(id);
				 //return JsonConvert.SerializeObject(lTgoodss.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]Tgoods tgoods)
			{
				 //Create
				 db.Tgoods.Add(tgoods);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tgoods);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]Tgoods tgoods)
			{
				 //Update
				 db.Tgoods.Update(tgoods);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]Tgoods tgoods)
			{
				 db.Tgoods.Remove(tgoods);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
