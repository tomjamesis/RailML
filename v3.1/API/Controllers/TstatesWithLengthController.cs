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
	public class TstatesWithLengthsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TstatesWithLength> lTstatesWithLengths = await db.TstatesWithLength.GetAllCompanyTstatesWithLengths(id);
				 //return JsonConvert.SerializeObject(lTstatesWithLengths.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TstatesWithLength tstateswithlength)
			{
				 //Create
				 db.TstatesWithLength.Add(tstateswithlength);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tstateswithlength);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TstatesWithLength tstateswithlength)
			{
				 //Update
				 db.TstatesWithLength.Update(tstateswithlength);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TstatesWithLength tstateswithlength)
			{
				 db.TstatesWithLength.Remove(tstateswithlength);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
