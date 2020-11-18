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
	public class EoperatingPeriodRefsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<EoperatingPeriodRef> lEoperatingPeriodRefs = await db.EoperatingPeriodRef.GetAllCompanyEoperatingPeriodRefs(id);
				 //return JsonConvert.SerializeObject(lEoperatingPeriodRefs.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]EoperatingPeriodRef eoperatingperiodref)
			{
				 //Create
				 db.EoperatingPeriodRef.Add(eoperatingperiodref);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(eoperatingperiodref);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]EoperatingPeriodRef eoperatingperiodref)
			{
				 //Update
				 db.EoperatingPeriodRef.Update(eoperatingperiodref);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]EoperatingPeriodRef eoperatingperiodref)
			{
				 db.EoperatingPeriodRef.Remove(eoperatingperiodref);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
