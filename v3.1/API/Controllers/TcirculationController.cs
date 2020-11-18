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
	public class TcirculationsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<Tcirculation> lTcirculations = await db.Tcirculation.GetAllCompanyTcirculations(id);
				 //return JsonConvert.SerializeObject(lTcirculations.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]Tcirculation tcirculation)
			{
				 //Create
				 db.Tcirculation.Add(tcirculation);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tcirculation);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]Tcirculation tcirculation)
			{
				 //Update
				 db.Tcirculation.Update(tcirculation);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]Tcirculation tcirculation)
			{
				 db.Tcirculation.Remove(tcirculation);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
