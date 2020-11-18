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
	public class TmonitoringsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<Tmonitoring> lTmonitorings = await db.Tmonitoring.GetAllCompanyTmonitorings(id);
				 //return JsonConvert.SerializeObject(lTmonitorings.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]Tmonitoring tmonitoring)
			{
				 //Create
				 db.Tmonitoring.Add(tmonitoring);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tmonitoring);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]Tmonitoring tmonitoring)
			{
				 //Update
				 db.Tmonitoring.Update(tmonitoring);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]Tmonitoring tmonitoring)
			{
				 db.Tmonitoring.Remove(tmonitoring);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
