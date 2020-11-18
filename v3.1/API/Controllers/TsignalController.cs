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
	public class TsignalsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<Tsignal> lTsignals = await db.Tsignal.GetAllCompanyTsignals(id);
				 //return JsonConvert.SerializeObject(lTsignals.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]Tsignal tsignal)
			{
				 //Create
				 db.Tsignal.Add(tsignal);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tsignal);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]Tsignal tsignal)
			{
				 //Update
				 db.Tsignal.Update(tsignal);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]Tsignal tsignal)
			{
				 db.Tsignal.Remove(tsignal);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
