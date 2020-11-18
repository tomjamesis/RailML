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
	public class EgaugeChangessController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<EgaugeChanges> lEgaugeChangess = await db.EgaugeChanges.GetAllCompanyEgaugeChangess(id);
				 //return JsonConvert.SerializeObject(lEgaugeChangess.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]EgaugeChanges egaugechanges)
			{
				 //Create
				 db.EgaugeChanges.Add(egaugechanges);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(egaugechanges);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]EgaugeChanges egaugechanges)
			{
				 //Update
				 db.EgaugeChanges.Update(egaugechanges);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]EgaugeChanges egaugechanges)
			{
				 db.EgaugeChanges.Remove(egaugechanges);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
