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
	public class EserviceSectionssController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<EserviceSections> lEserviceSectionss = await db.EserviceSections.GetAllCompanyEserviceSectionss(id);
				 //return JsonConvert.SerializeObject(lEserviceSectionss.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]EserviceSections eservicesections)
			{
				 //Create
				 db.EserviceSections.Add(eservicesections);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(eservicesections);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]EserviceSections eservicesections)
			{
				 //Update
				 db.EserviceSections.Update(eservicesections);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]EserviceSections eservicesections)
			{
				 db.EserviceSections.Remove(eservicesections);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
