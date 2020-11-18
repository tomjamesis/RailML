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
	public class TsignalBasesController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TsignalBase> lTsignalBases = await db.TsignalBase.GetAllCompanyTsignalBases(id);
				 //return JsonConvert.SerializeObject(lTsignalBases.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TsignalBase tsignalbase)
			{
				 //Create
				 db.TsignalBase.Add(tsignalbase);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tsignalbase);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TsignalBase tsignalbase)
			{
				 //Update
				 db.TsignalBase.Update(tsignalbase);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TsignalBase tsignalbase)
			{
				 db.TsignalBase.Remove(tsignalbase);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
