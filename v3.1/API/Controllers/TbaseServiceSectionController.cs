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
	public class TbaseServiceSectionsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TbaseServiceSection> lTbaseServiceSections = await db.TbaseServiceSection.GetAllCompanyTbaseServiceSections(id);
				 //return JsonConvert.SerializeObject(lTbaseServiceSections.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TbaseServiceSection tbaseservicesection)
			{
				 //Create
				 db.TbaseServiceSection.Add(tbaseservicesection);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tbaseservicesection);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TbaseServiceSection tbaseservicesection)
			{
				 //Update
				 db.TbaseServiceSection.Update(tbaseservicesection);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TbaseServiceSection tbaseservicesection)
			{
				 db.TbaseServiceSection.Remove(tbaseservicesection);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
