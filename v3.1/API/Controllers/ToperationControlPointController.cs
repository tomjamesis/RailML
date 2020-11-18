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
	public class ToperationControlPointsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<ToperationControlPoint> lToperationControlPoints = await db.ToperationControlPoint.GetAllCompanyToperationControlPoints(id);
				 //return JsonConvert.SerializeObject(lToperationControlPoints.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]ToperationControlPoint toperationcontrolpoint)
			{
				 //Create
				 db.ToperationControlPoint.Add(toperationcontrolpoint);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(toperationcontrolpoint);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]ToperationControlPoint toperationcontrolpoint)
			{
				 //Update
				 db.ToperationControlPoint.Update(toperationcontrolpoint);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]ToperationControlPoint toperationcontrolpoint)
			{
				 db.ToperationControlPoint.Remove(toperationcontrolpoint);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
