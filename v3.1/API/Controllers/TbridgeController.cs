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
	public class TbridgesController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<Tbridge> lTbridges = await db.Tbridge.GetAllCompanyTbridges(id);
				 //return JsonConvert.SerializeObject(lTbridges.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]Tbridge tbridge)
			{
				 //Create
				 db.Tbridge.Add(tbridge);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tbridge);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]Tbridge tbridge)
			{
				 //Update
				 db.Tbridge.Update(tbridge);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]Tbridge tbridge)
			{
				 db.Tbridge.Remove(tbridge);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
