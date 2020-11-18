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
	public class EocsElementssController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<EocsElements> lEocsElementss = await db.EocsElements.GetAllCompanyEocsElementss(id);
				 //return JsonConvert.SerializeObject(lEocsElementss.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]EocsElements eocselements)
			{
				 //Create
				 db.EocsElements.Add(eocselements);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(eocselements);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]EocsElements eocselements)
			{
				 //Update
				 db.EocsElements.Update(eocselements);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]EocsElements eocselements)
			{
				 db.EocsElements.Remove(eocselements);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
