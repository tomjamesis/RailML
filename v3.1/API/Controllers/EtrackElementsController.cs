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
	public class EtrackElementssController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<EtrackElements> lEtrackElementss = await db.EtrackElements.GetAllCompanyEtrackElementss(id);
				 //return JsonConvert.SerializeObject(lEtrackElementss.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]EtrackElements etrackelements)
			{
				 //Create
				 db.EtrackElements.Add(etrackelements);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(etrackelements);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]EtrackElements etrackelements)
			{
				 //Update
				 db.EtrackElements.Update(etrackelements);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]EtrackElements etrackelements)
			{
				 db.EtrackElements.Remove(etrackelements);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
