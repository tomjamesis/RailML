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
	public class EelectricalCouplersController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<EelectricalCoupler> lEelectricalCouplers = await db.EelectricalCoupler.GetAllCompanyEelectricalCouplers(id);
				 //return JsonConvert.SerializeObject(lEelectricalCouplers.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]EelectricalCoupler eelectricalcoupler)
			{
				 //Create
				 db.EelectricalCoupler.Add(eelectricalcoupler);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(eelectricalcoupler);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]EelectricalCoupler eelectricalcoupler)
			{
				 //Update
				 db.EelectricalCoupler.Update(eelectricalcoupler);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]EelectricalCoupler eelectricalcoupler)
			{
				 db.EelectricalCoupler.Remove(eelectricalcoupler);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
