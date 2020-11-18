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
	public class TocpCenterSidesController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TocpCenterSide> lTocpCenterSides = await db.TocpCenterSide.GetAllCompanyTocpCenterSides(id);
				 //return JsonConvert.SerializeObject(lTocpCenterSides.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TocpCenterSide tocpcenterside)
			{
				 //Create
				 db.TocpCenterSide.Add(tocpcenterside);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tocpcenterside);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TocpCenterSide tocpcenterside)
			{
				 //Update
				 db.TocpCenterSide.Update(tocpcenterside);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TocpCenterSide tocpcenterside)
			{
				 db.TocpCenterSide.Remove(tocpcenterside);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
