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
	public class EbridgesController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<Ebridge> lEbridges = await db.Ebridge.GetAllCompanyEbridges(id);
				 //return JsonConvert.SerializeObject(lEbridges.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]Ebridge ebridge)
			{
				 //Create
				 db.Ebridge.Add(ebridge);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(ebridge);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]Ebridge ebridge)
			{
				 //Update
				 db.Ebridge.Update(ebridge);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]Ebridge ebridge)
			{
				 db.Ebridge.Remove(ebridge);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
