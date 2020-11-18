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
	public class EoperationControlPointssController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<EoperationControlPoints> lEoperationControlPointss = await db.EoperationControlPoints.GetAllCompanyEoperationControlPointss(id);
				 //return JsonConvert.SerializeObject(lEoperationControlPointss.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]EoperationControlPoints eoperationcontrolpoints)
			{
				 //Create
				 db.EoperationControlPoints.Add(eoperationcontrolpoints);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(eoperationcontrolpoints);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]EoperationControlPoints eoperationcontrolpoints)
			{
				 //Update
				 db.EoperationControlPoints.Update(eoperationcontrolpoints);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]EoperationControlPoints eoperationcontrolpoints)
			{
				 db.EoperationControlPoints.Remove(eoperationcontrolpoints);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
