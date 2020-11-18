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
	public class TcurvesController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<Tcurve> lTcurves = await db.Tcurve.GetAllCompanyTcurves(id);
				 //return JsonConvert.SerializeObject(lTcurves.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]Tcurve tcurve)
			{
				 //Create
				 db.Tcurve.Add(tcurve);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tcurve);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]Tcurve tcurve)
			{
				 //Update
				 db.Tcurve.Update(tcurve);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]Tcurve tcurve)
			{
				 db.Tcurve.Remove(tcurve);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
