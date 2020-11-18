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
	public class TocpPropOthersController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TocpPropOther> lTocpPropOthers = await db.TocpPropOther.GetAllCompanyTocpPropOthers(id);
				 //return JsonConvert.SerializeObject(lTocpPropOthers.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TocpPropOther tocppropother)
			{
				 //Create
				 db.TocpPropOther.Add(tocppropother);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tocppropother);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TocpPropOther tocppropother)
			{
				 //Update
				 db.TocpPropOther.Update(tocppropother);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TocpPropOther tocppropother)
			{
				 db.TocpPropOther.Remove(tocppropother);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
