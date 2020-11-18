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
	public class EcrossedElementssController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<EcrossedElements> lEcrossedElementss = await db.EcrossedElements.GetAllCompanyEcrossedElementss(id);
				 //return JsonConvert.SerializeObject(lEcrossedElementss.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]EcrossedElements ecrossedelements)
			{
				 //Create
				 db.EcrossedElements.Add(ecrossedelements);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(ecrossedelements);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]EcrossedElements ecrossedelements)
			{
				 //Update
				 db.EcrossedElements.Update(ecrossedelements);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]EcrossedElements ecrossedelements)
			{
				 db.EcrossedElements.Remove(ecrossedelements);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
