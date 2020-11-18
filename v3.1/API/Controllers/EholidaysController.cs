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
	public class EholidayssController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<Eholidays> lEholidayss = await db.Eholidays.GetAllCompanyEholidayss(id);
				 //return JsonConvert.SerializeObject(lEholidayss.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]Eholidays eholidays)
			{
				 //Create
				 db.Eholidays.Add(eholidays);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(eholidays);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]Eholidays eholidays)
			{
				 //Update
				 db.Eholidays.Update(eholidays);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]Eholidays eholidays)
			{
				 db.Eholidays.Remove(eholidays);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
