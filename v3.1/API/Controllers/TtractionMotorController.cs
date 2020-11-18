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
	public class TtractionMotorsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TtractionMotor> lTtractionMotors = await db.TtractionMotor.GetAllCompanyTtractionMotors(id);
				 //return JsonConvert.SerializeObject(lTtractionMotors.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TtractionMotor ttractionmotor)
			{
				 //Create
				 db.TtractionMotor.Add(ttractionmotor);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(ttractionmotor);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TtractionMotor ttractionmotor)
			{
				 //Update
				 db.TtractionMotor.Update(ttractionmotor);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TtractionMotor ttractionmotor)
			{
				 db.TtractionMotor.Remove(ttractionmotor);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
