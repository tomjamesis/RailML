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
	public class TocpRefInGroupsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TocpRefInGroup> lTocpRefInGroups = await db.TocpRefInGroup.GetAllCompanyTocpRefInGroups(id);
				 //return JsonConvert.SerializeObject(lTocpRefInGroups.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TocpRefInGroup tocprefingroup)
			{
				 //Create
				 db.TocpRefInGroup.Add(tocprefingroup);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tocprefingroup);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TocpRefInGroup tocprefingroup)
			{
				 //Update
				 db.TocpRefInGroup.Update(tocprefingroup);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TocpRefInGroup tocprefingroup)
			{
				 db.TocpRefInGroup.Remove(tocprefingroup);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
