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
	public class TstatisticsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<Tstatistic> lTstatistics = await db.Tstatistic.GetAllCompanyTstatistics(id);
				 //return JsonConvert.SerializeObject(lTstatistics.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]Tstatistic tstatistic)
			{
				 //Create
				 db.Tstatistic.Add(tstatistic);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tstatistic);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]Tstatistic tstatistic)
			{
				 //Update
				 db.Tstatistic.Update(tstatistic);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]Tstatistic tstatistic)
			{
				 db.Tstatistic.Remove(tstatistic);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
