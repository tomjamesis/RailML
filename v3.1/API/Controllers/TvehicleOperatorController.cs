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
	public class TvehicleOperatorsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TvehicleOperator> lTvehicleOperators = await db.TvehicleOperator.GetAllCompanyTvehicleOperators(id);
				 //return JsonConvert.SerializeObject(lTvehicleOperators.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TvehicleOperator tvehicleoperator)
			{
				 //Create
				 db.TvehicleOperator.Add(tvehicleoperator);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tvehicleoperator);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TvehicleOperator tvehicleoperator)
			{
				 //Update
				 db.TvehicleOperator.Update(tvehicleoperator);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TvehicleOperator tvehicleoperator)
			{
				 db.TvehicleOperator.Remove(tvehicleoperator);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
