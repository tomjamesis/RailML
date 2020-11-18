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
	public class TserviceSectionsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TserviceSection> lTserviceSections = await db.TserviceSection.GetAllCompanyTserviceSections(id);
				 //return JsonConvert.SerializeObject(lTserviceSections.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TserviceSection tservicesection)
			{
				 //Create
				 db.TserviceSection.Add(tservicesection);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tservicesection);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TserviceSection tservicesection)
			{
				 //Update
				 db.TserviceSection.Update(tservicesection);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TserviceSection tservicesection)
			{
				 db.TserviceSection.Remove(tservicesection);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
