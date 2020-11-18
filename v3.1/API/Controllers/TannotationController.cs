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
	public class TannotationsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<Tannotation> lTannotations = await db.Tannotation.GetAllCompanyTannotations(id);
				 //return JsonConvert.SerializeObject(lTannotations.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]Tannotation tannotation)
			{
				 //Create
				 db.Tannotation.Add(tannotation);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tannotation);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]Tannotation tannotation)
			{
				 //Update
				 db.Tannotation.Update(tannotation);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]Tannotation tannotation)
			{
				 db.Tannotation.Remove(tannotation);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
