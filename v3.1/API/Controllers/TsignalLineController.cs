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
	public class TsignalLinesController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TsignalLine> lTsignalLines = await db.TsignalLine.GetAllCompanyTsignalLines(id);
				 //return JsonConvert.SerializeObject(lTsignalLines.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TsignalLine tsignalline)
			{
				 //Create
				 db.TsignalLine.Add(tsignalline);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tsignalline);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TsignalLine tsignalline)
			{
				 //Update
				 db.TsignalLine.Update(tsignalline);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TsignalLine tsignalline)
			{
				 db.TsignalLine.Remove(tsignalline);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
