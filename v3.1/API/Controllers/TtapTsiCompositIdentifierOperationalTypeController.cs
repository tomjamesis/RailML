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
	public class TtapTsiCompositIdentifierOperationalTypesController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TtapTsiCompositIdentifierOperationalType> lTtapTsiCompositIdentifierOperationalTypes = await db.TtapTsiCompositIdentifierOperationalType.GetAllCompanyTtapTsiCompositIdentifierOperationalTypes(id);
				 //return JsonConvert.SerializeObject(lTtapTsiCompositIdentifierOperationalTypes.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TtapTsiCompositIdentifierOperationalType ttaptsicompositidentifieroperationaltype)
			{
				 //Create
				 db.TtapTsiCompositIdentifierOperationalType.Add(ttaptsicompositidentifieroperationaltype);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(ttaptsicompositidentifieroperationaltype);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TtapTsiCompositIdentifierOperationalType ttaptsicompositidentifieroperationaltype)
			{
				 //Update
				 db.TtapTsiCompositIdentifierOperationalType.Update(ttaptsicompositidentifieroperationaltype);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TtapTsiCompositIdentifierOperationalType ttaptsicompositidentifieroperationaltype)
			{
				 db.TtapTsiCompositIdentifierOperationalType.Remove(ttaptsicompositidentifieroperationaltype);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
