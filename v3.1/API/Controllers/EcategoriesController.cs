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
	public class EcategoriessController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<Ecategories> lEcategoriess = await db.Ecategories.GetAllCompanyEcategoriess(id);
				 //return JsonConvert.SerializeObject(lEcategoriess.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]Ecategories ecategories)
			{
				 //Create
				 db.Ecategories.Add(ecategories);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(ecategories);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]Ecategories ecategories)
			{
				 //Update
				 db.Ecategories.Update(ecategories);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]Ecategories ecategories)
			{
				 db.Ecategories.Remove(ecategories);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
