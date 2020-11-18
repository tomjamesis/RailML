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
	public class TsignalEtcssController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TsignalEtcs> lTsignalEtcss = await db.TsignalEtcs.GetAllCompanyTsignalEtcss(id);
				 //return JsonConvert.SerializeObject(lTsignalEtcss.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TsignalEtcs tsignaletcs)
			{
				 //Create
				 db.TsignalEtcs.Add(tsignaletcs);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tsignaletcs);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TsignalEtcs tsignaletcs)
			{
				 //Update
				 db.TsignalEtcs.Update(tsignaletcs);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TsignalEtcs tsignaletcs)
			{
				 db.TsignalEtcs.Remove(tsignaletcs);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
