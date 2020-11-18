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
	public class TtopologyReferencesController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TtopologyReference> lTtopologyReferences = await db.TtopologyReference.GetAllCompanyTtopologyReferences(id);
				 //return JsonConvert.SerializeObject(lTtopologyReferences.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TtopologyReference ttopologyreference)
			{
				 //Create
				 db.TtopologyReference.Add(ttopologyreference);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(ttopologyreference);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TtopologyReference ttopologyreference)
			{
				 //Update
				 db.TtopologyReference.Update(ttopologyreference);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TtopologyReference ttopologyreference)
			{
				 db.TtopologyReference.Remove(ttopologyreference);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
