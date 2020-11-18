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
	public class EcategorysController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<Ecategory> lEcategorys = await db.Ecategory.GetAllCompanyEcategorys(id);
				 //return JsonConvert.SerializeObject(lEcategorys.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]Ecategory ecategory)
			{
				 //Create
				 db.Ecategory.Add(ecategory);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(ecategory);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]Ecategory ecategory)
			{
				 //Update
				 db.Ecategory.Update(ecategory);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]Ecategory ecategory)
			{
				 db.Ecategory.Remove(ecategory);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
