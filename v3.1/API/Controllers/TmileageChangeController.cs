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
	public class TmileageChangesController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TmileageChange> lTmileageChanges = await db.TmileageChange.GetAllCompanyTmileageChanges(id);
				 //return JsonConvert.SerializeObject(lTmileageChanges.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TmileageChange tmileagechange)
			{
				 //Create
				 db.TmileageChange.Add(tmileagechange);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tmileagechange);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TmileageChange tmileagechange)
			{
				 //Update
				 db.TmileageChange.Update(tmileagechange);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TmileageChange tmileagechange)
			{
				 db.TmileageChange.Remove(tmileagechange);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
