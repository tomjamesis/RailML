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
	public class TcurrentCurvesController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TcurrentCurve> lTcurrentCurves = await db.TcurrentCurve.GetAllCompanyTcurrentCurves(id);
				 //return JsonConvert.SerializeObject(lTcurrentCurves.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TcurrentCurve tcurrentcurve)
			{
				 //Create
				 db.TcurrentCurve.Add(tcurrentcurve);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tcurrentcurve);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TcurrentCurve tcurrentcurve)
			{
				 //Update
				 db.TcurrentCurve.Update(tcurrentcurve);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TcurrentCurve tcurrentcurve)
			{
				 db.TcurrentCurve.Remove(tcurrentcurve);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
