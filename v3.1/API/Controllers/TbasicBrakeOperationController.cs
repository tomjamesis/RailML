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
	public class TbasicBrakeOperationsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TbasicBrakeOperation> lTbasicBrakeOperations = await db.TbasicBrakeOperation.GetAllCompanyTbasicBrakeOperations(id);
				 //return JsonConvert.SerializeObject(lTbasicBrakeOperations.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TbasicBrakeOperation tbasicbrakeoperation)
			{
				 //Create
				 db.TbasicBrakeOperation.Add(tbasicbrakeoperation);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tbasicbrakeoperation);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TbasicBrakeOperation tbasicbrakeoperation)
			{
				 //Update
				 db.TbasicBrakeOperation.Update(tbasicbrakeoperation);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TbasicBrakeOperation tbasicbrakeoperation)
			{
				 db.TbasicBrakeOperation.Remove(tbasicbrakeoperation);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
