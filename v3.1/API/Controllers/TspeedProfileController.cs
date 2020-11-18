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
	public class TspeedProfilesController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TspeedProfile> lTspeedProfiles = await db.TspeedProfile.GetAllCompanyTspeedProfiles(id);
				 //return JsonConvert.SerializeObject(lTspeedProfiles.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TspeedProfile tspeedprofile)
			{
				 //Create
				 db.TspeedProfile.Add(tspeedprofile);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tspeedprofile);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TspeedProfile tspeedprofile)
			{
				 //Update
				 db.TspeedProfile.Update(tspeedprofile);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TspeedProfile tspeedprofile)
			{
				 db.TspeedProfile.Remove(tspeedprofile);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
