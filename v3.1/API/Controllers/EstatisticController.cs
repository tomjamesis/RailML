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
	public class EstatisticsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<Estatistic> lEstatistics = await db.Estatistic.GetAllCompanyEstatistics(id);
				 //return JsonConvert.SerializeObject(lEstatistics.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]Estatistic estatistic)
			{
				 //Create
				 db.Estatistic.Add(estatistic);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(estatistic);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]Estatistic estatistic)
			{
				 //Update
				 db.Estatistic.Update(estatistic);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]Estatistic estatistic)
			{
				 db.Estatistic.Remove(estatistic);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
