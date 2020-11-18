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
	public class TstatisticTimessController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TstatisticTimes> lTstatisticTimess = await db.TstatisticTimes.GetAllCompanyTstatisticTimess(id);
				 //return JsonConvert.SerializeObject(lTstatisticTimess.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TstatisticTimes tstatistictimes)
			{
				 //Create
				 db.TstatisticTimes.Add(tstatistictimes);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tstatistictimes);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TstatisticTimes tstatistictimes)
			{
				 //Update
				 db.TstatisticTimes.Update(tstatistictimes);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TstatisticTimes tstatistictimes)
			{
				 db.TstatisticTimes.Remove(tstatistictimes);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
