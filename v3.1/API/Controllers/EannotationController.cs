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
	public class EannotationsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<Eannotation> lEannotations = await db.Eannotation.GetAllCompanyEannotations(id);
				 //return JsonConvert.SerializeObject(lEannotations.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]Eannotation eannotation)
			{
				 //Create
				 db.Eannotation.Add(eannotation);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(eannotation);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]Eannotation eannotation)
			{
				 //Update
				 db.Eannotation.Update(eannotation);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]Eannotation eannotation)
			{
				 db.Eannotation.Remove(eannotation);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
