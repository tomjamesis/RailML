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
	public class TstoragesController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<Tstorage> lTstorages = await db.Tstorage.GetAllCompanyTstorages(id);
				 //return JsonConvert.SerializeObject(lTstorages.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]Tstorage tstorage)
			{
				 //Create
				 db.Tstorage.Add(tstorage);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tstorage);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]Tstorage tstorage)
			{
				 //Update
				 db.Tstorage.Update(tstorage);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]Tstorage tstorage)
			{
				 db.Tstorage.Remove(tstorage);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
