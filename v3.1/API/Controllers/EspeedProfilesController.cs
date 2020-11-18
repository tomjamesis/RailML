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
	public class EspeedProfilessController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<EspeedProfiles> lEspeedProfiless = await db.EspeedProfiles.GetAllCompanyEspeedProfiless(id);
				 //return JsonConvert.SerializeObject(lEspeedProfiless.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]EspeedProfiles espeedprofiles)
			{
				 //Create
				 db.EspeedProfiles.Add(espeedprofiles);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(espeedprofiles);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]EspeedProfiles espeedprofiles)
			{
				 //Update
				 db.EspeedProfiles.Update(espeedprofiles);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]EspeedProfiles espeedprofiles)
			{
				 db.EspeedProfiles.Remove(espeedprofiles);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
