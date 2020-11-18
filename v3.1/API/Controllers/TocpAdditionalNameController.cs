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
	public class TocpAdditionalNamesController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TocpAdditionalName> lTocpAdditionalNames = await db.TocpAdditionalName.GetAllCompanyTocpAdditionalNames(id);
				 //return JsonConvert.SerializeObject(lTocpAdditionalNames.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TocpAdditionalName tocpadditionalname)
			{
				 //Create
				 db.TocpAdditionalName.Add(tocpadditionalname);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tocpadditionalname);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TocpAdditionalName tocpadditionalname)
			{
				 //Update
				 db.TocpAdditionalName.Update(tocpadditionalname);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TocpAdditionalName tocpadditionalname)
			{
				 db.TocpAdditionalName.Remove(tocpadditionalname);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
