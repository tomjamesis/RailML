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
	public class TcurvingLimitationTypesController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TcurvingLimitationType> lTcurvingLimitationTypes = await db.TcurvingLimitationType.GetAllCompanyTcurvingLimitationTypes(id);
				 //return JsonConvert.SerializeObject(lTcurvingLimitationTypes.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TcurvingLimitationType tcurvinglimitationtype)
			{
				 //Create
				 db.TcurvingLimitationType.Add(tcurvinglimitationtype);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tcurvinglimitationtype);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TcurvingLimitationType tcurvinglimitationtype)
			{
				 //Update
				 db.TcurvingLimitationType.Update(tcurvinglimitationtype);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TcurvingLimitationType tcurvinglimitationtype)
			{
				 db.TcurvingLimitationType.Remove(tcurvinglimitationtype);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
