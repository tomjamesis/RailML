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
	public class TocpAreasController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TocpArea> lTocpAreas = await db.TocpArea.GetAllCompanyTocpAreas(id);
				 //return JsonConvert.SerializeObject(lTocpAreas.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TocpArea tocparea)
			{
				 //Create
				 db.TocpArea.Add(tocparea);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tocparea);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TocpArea tocparea)
			{
				 //Update
				 db.TocpArea.Update(tocparea);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TocpArea tocparea)
			{
				 db.TocpArea.Remove(tocparea);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
