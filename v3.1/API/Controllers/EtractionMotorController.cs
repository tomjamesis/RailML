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
	public class EtractionMotorsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<EtractionMotor> lEtractionMotors = await db.EtractionMotor.GetAllCompanyEtractionMotors(id);
				 //return JsonConvert.SerializeObject(lEtractionMotors.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]EtractionMotor etractionmotor)
			{
				 //Create
				 db.EtractionMotor.Add(etractionmotor);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(etractionmotor);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]EtractionMotor etractionmotor)
			{
				 //Update
				 db.EtractionMotor.Update(etractionmotor);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]EtractionMotor etractionmotor)
			{
				 db.EtractionMotor.Remove(etractionmotor);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
