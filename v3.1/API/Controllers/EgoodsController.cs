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
	public class EgoodssController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<Egoods> lEgoodss = await db.Egoods.GetAllCompanyEgoodss(id);
				 //return JsonConvert.SerializeObject(lEgoodss.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]Egoods egoods)
			{
				 //Create
				 db.Egoods.Add(egoods);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(egoods);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]Egoods egoods)
			{
				 //Update
				 db.Egoods.Update(egoods);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]Egoods egoods)
			{
				 db.Egoods.Remove(egoods);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
