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
	public class TeffortCurvesController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TeffortCurve> lTeffortCurves = await db.TeffortCurve.GetAllCompanyTeffortCurves(id);
				 //return JsonConvert.SerializeObject(lTeffortCurves.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TeffortCurve teffortcurve)
			{
				 //Create
				 db.TeffortCurve.Add(teffortcurve);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(teffortcurve);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TeffortCurve teffortcurve)
			{
				 //Update
				 db.TeffortCurve.Update(teffortcurve);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TeffortCurve teffortcurve)
			{
				 db.TeffortCurve.Remove(teffortcurve);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
