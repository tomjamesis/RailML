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
	public class TefficiencyCurvesController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TefficiencyCurve> lTefficiencyCurves = await db.TefficiencyCurve.GetAllCompanyTefficiencyCurves(id);
				 //return JsonConvert.SerializeObject(lTefficiencyCurves.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TefficiencyCurve tefficiencycurve)
			{
				 //Create
				 db.TefficiencyCurve.Add(tefficiencycurve);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tefficiencycurve);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TefficiencyCurve tefficiencycurve)
			{
				 //Update
				 db.TefficiencyCurve.Update(tefficiencycurve);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TefficiencyCurve tefficiencycurve)
			{
				 db.TefficiencyCurve.Remove(tefficiencycurve);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
