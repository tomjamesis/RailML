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
	public class TmileageChangeDescrsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TmileageChangeDescr> lTmileageChangeDescrs = await db.TmileageChangeDescr.GetAllCompanyTmileageChangeDescrs(id);
				 //return JsonConvert.SerializeObject(lTmileageChangeDescrs.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TmileageChangeDescr tmileagechangedescr)
			{
				 //Create
				 db.TmileageChangeDescr.Add(tmileagechangedescr);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tmileagechangedescr);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TmileageChangeDescr tmileagechangedescr)
			{
				 //Update
				 db.TmileageChangeDescr.Update(tmileagechangedescr);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TmileageChangeDescr tmileagechangedescr)
			{
				 db.TmileageChangeDescr.Remove(tmileagechangedescr);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
