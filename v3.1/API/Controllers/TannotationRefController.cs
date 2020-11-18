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
	public class TannotationRefsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TannotationRef> lTannotationRefs = await db.TannotationRef.GetAllCompanyTannotationRefs(id);
				 //return JsonConvert.SerializeObject(lTannotationRefs.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TannotationRef tannotationref)
			{
				 //Create
				 db.TannotationRef.Add(tannotationref);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tannotationref);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TannotationRef tannotationref)
			{
				 //Update
				 db.TannotationRef.Update(tannotationref);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TannotationRef tannotationref)
			{
				 db.TannotationRef.Remove(tannotationref);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
