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
	public class EgradientChangessController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<EgradientChanges> lEgradientChangess = await db.EgradientChanges.GetAllCompanyEgradientChangess(id);
				 //return JsonConvert.SerializeObject(lEgradientChangess.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]EgradientChanges egradientchanges)
			{
				 //Create
				 db.EgradientChanges.Add(egradientchanges);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(egradientchanges);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]EgradientChanges egradientchanges)
			{
				 //Update
				 db.EgradientChanges.Update(egradientchanges);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]EgradientChanges egradientchanges)
			{
				 db.EgradientChanges.Remove(egradientchanges);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
