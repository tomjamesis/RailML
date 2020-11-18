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
	public class ToperatingPeriodRefsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<ToperatingPeriodRef> lToperatingPeriodRefs = await db.ToperatingPeriodRef.GetAllCompanyToperatingPeriodRefs(id);
				 //return JsonConvert.SerializeObject(lToperatingPeriodRefs.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]ToperatingPeriodRef toperatingperiodref)
			{
				 //Create
				 db.ToperatingPeriodRef.Add(toperatingperiodref);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(toperatingperiodref);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]ToperatingPeriodRef toperatingperiodref)
			{
				 //Update
				 db.ToperatingPeriodRef.Update(toperatingperiodref);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]ToperatingPeriodRef toperatingperiodref)
			{
				 db.ToperatingPeriodRef.Remove(toperatingperiodref);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
