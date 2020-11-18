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
	public class TsignalCatenarysController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TsignalCatenary> lTsignalCatenarys = await db.TsignalCatenary.GetAllCompanyTsignalCatenarys(id);
				 //return JsonConvert.SerializeObject(lTsignalCatenarys.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TsignalCatenary tsignalcatenary)
			{
				 //Create
				 db.TsignalCatenary.Add(tsignalcatenary);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tsignalcatenary);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TsignalCatenary tsignalcatenary)
			{
				 //Update
				 db.TsignalCatenary.Update(tsignalcatenary);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TsignalCatenary tsignalcatenary)
			{
				 db.TsignalCatenary.Remove(tsignalcatenary);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
