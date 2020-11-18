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
	public class TspeedProfileRefsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TspeedProfileRef> lTspeedProfileRefs = await db.TspeedProfileRef.GetAllCompanyTspeedProfileRefs(id);
				 //return JsonConvert.SerializeObject(lTspeedProfileRefs.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TspeedProfileRef tspeedprofileref)
			{
				 //Create
				 db.TspeedProfileRef.Add(tspeedprofileref);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tspeedprofileref);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TspeedProfileRef tspeedprofileref)
			{
				 //Update
				 db.TspeedProfileRef.Update(tspeedprofileref);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TspeedProfileRef tspeedprofileref)
			{
				 db.TspeedProfileRef.Remove(tspeedprofileref);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
