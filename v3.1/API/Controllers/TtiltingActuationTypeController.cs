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
	public class TtiltingActuationTypesController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TtiltingActuationType> lTtiltingActuationTypes = await db.TtiltingActuationType.GetAllCompanyTtiltingActuationTypes(id);
				 //return JsonConvert.SerializeObject(lTtiltingActuationTypes.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TtiltingActuationType ttiltingactuationtype)
			{
				 //Create
				 db.TtiltingActuationType.Add(ttiltingactuationtype);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(ttiltingactuationtype);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TtiltingActuationType ttiltingactuationtype)
			{
				 //Update
				 db.TtiltingActuationType.Update(ttiltingactuationtype);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TtiltingActuationType ttiltingactuationtype)
			{
				 db.TtiltingActuationType.Remove(ttiltingactuationtype);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
