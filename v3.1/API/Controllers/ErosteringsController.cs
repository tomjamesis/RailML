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
	public class ErosteringssController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<Erosterings> lErosteringss = await db.Erosterings.GetAllCompanyErosteringss(id);
				 //return JsonConvert.SerializeObject(lErosteringss.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]Erosterings erosterings)
			{
				 //Create
				 db.Erosterings.Add(erosterings);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(erosterings);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]Erosterings erosterings)
			{
				 //Update
				 db.Erosterings.Update(erosterings);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]Erosterings erosterings)
			{
				 db.Erosterings.Remove(erosterings);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
