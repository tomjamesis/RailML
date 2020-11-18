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
	public class EmileageChangessController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<EmileageChanges> lEmileageChangess = await db.EmileageChanges.GetAllCompanyEmileageChangess(id);
				 //return JsonConvert.SerializeObject(lEmileageChangess.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]EmileageChanges emileagechanges)
			{
				 //Create
				 db.EmileageChanges.Add(emileagechanges);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(emileagechanges);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]EmileageChanges emileagechanges)
			{
				 //Update
				 db.EmileageChanges.Update(emileagechanges);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]EmileageChanges emileagechanges)
			{
				 db.EmileageChanges.Remove(emileagechanges);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
