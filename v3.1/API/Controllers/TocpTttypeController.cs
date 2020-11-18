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
	public class TocpTttypesController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TocpTttype> lTocpTttypes = await db.TocpTttype.GetAllCompanyTocpTttypes(id);
				 //return JsonConvert.SerializeObject(lTocpTttypes.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TocpTttype tocptttype)
			{
				 //Create
				 db.TocpTttype.Add(tocptttype);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tocptttype);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TocpTttype tocptttype)
			{
				 //Update
				 db.TocpTttype.Update(tocptttype);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TocpTttype tocptttype)
			{
				 db.TocpTttype.Remove(tocptttype);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
