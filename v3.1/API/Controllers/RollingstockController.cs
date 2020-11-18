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
	public class RollingstocksController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<Rollingstock> lRollingstocks = await db.Rollingstock.GetAllCompanyRollingstocks(id);
				 //return JsonConvert.SerializeObject(lRollingstocks.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]Rollingstock rollingstock)
			{
				 //Create
				 db.Rollingstock.Add(rollingstock);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(rollingstock);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]Rollingstock rollingstock)
			{
				 //Update
				 db.Rollingstock.Update(rollingstock);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]Rollingstock rollingstock)
			{
				 db.Rollingstock.Remove(rollingstock);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
