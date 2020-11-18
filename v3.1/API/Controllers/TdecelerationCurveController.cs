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
	public class TdecelerationCurvesController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TdecelerationCurve> lTdecelerationCurves = await db.TdecelerationCurve.GetAllCompanyTdecelerationCurves(id);
				 //return JsonConvert.SerializeObject(lTdecelerationCurves.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TdecelerationCurve tdecelerationcurve)
			{
				 //Create
				 db.TdecelerationCurve.Add(tdecelerationcurve);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tdecelerationcurve);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TdecelerationCurve tdecelerationcurve)
			{
				 //Update
				 db.TdecelerationCurve.Update(tdecelerationcurve);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TdecelerationCurve tdecelerationcurve)
			{
				 db.TdecelerationCurve.Remove(tdecelerationcurve);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
