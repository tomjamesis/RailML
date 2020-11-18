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
	public class TrollingstocksController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<Trollingstock> lTrollingstocks = await db.Trollingstock.GetAllCompanyTrollingstocks(id);
				 //return JsonConvert.SerializeObject(lTrollingstocks.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]Trollingstock trollingstock)
			{
				 //Create
				 db.Trollingstock.Add(trollingstock);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(trollingstock);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]Trollingstock trollingstock)
			{
				 //Update
				 db.Trollingstock.Update(trollingstock);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]Trollingstock trollingstock)
			{
				 db.Trollingstock.Remove(trollingstock);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
