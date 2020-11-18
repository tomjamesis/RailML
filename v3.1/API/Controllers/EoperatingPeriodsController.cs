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
	public class EoperatingPeriodssController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<EoperatingPeriods> lEoperatingPeriodss = await db.EoperatingPeriods.GetAllCompanyEoperatingPeriodss(id);
				 //return JsonConvert.SerializeObject(lEoperatingPeriodss.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]EoperatingPeriods eoperatingperiods)
			{
				 //Create
				 db.EoperatingPeriods.Add(eoperatingperiods);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(eoperatingperiods);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]EoperatingPeriods eoperatingperiods)
			{
				 //Update
				 db.EoperatingPeriods.Update(eoperatingperiods);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]EoperatingPeriods eoperatingperiods)
			{
				 db.EoperatingPeriods.Remove(eoperatingperiods);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
