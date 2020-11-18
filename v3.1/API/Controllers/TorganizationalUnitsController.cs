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
	public class TorganizationalUnitssController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TorganizationalUnits> lTorganizationalUnitss = await db.TorganizationalUnits.GetAllCompanyTorganizationalUnitss(id);
				 //return JsonConvert.SerializeObject(lTorganizationalUnitss.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TorganizationalUnits torganizationalunits)
			{
				 //Create
				 db.TorganizationalUnits.Add(torganizationalunits);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(torganizationalunits);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TorganizationalUnits torganizationalunits)
			{
				 //Update
				 db.TorganizationalUnits.Update(torganizationalunits);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TorganizationalUnits torganizationalunits)
			{
				 db.TorganizationalUnits.Remove(torganizationalunits);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
