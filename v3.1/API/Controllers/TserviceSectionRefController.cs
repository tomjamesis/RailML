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
	public class TserviceSectionRefsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TserviceSectionRef> lTserviceSectionRefs = await db.TserviceSectionRef.GetAllCompanyTserviceSectionRefs(id);
				 //return JsonConvert.SerializeObject(lTserviceSectionRefs.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TserviceSectionRef tservicesectionref)
			{
				 //Create
				 db.TserviceSectionRef.Add(tservicesectionref);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tservicesectionref);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TserviceSectionRef tservicesectionref)
			{
				 //Update
				 db.TserviceSectionRef.Update(tservicesectionref);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TserviceSectionRef tservicesectionref)
			{
				 db.TserviceSectionRef.Remove(tservicesectionref);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
