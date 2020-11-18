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
	public class TocpPropOperationalsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TocpPropOperational> lTocpPropOperationals = await db.TocpPropOperational.GetAllCompanyTocpPropOperationals(id);
				 //return JsonConvert.SerializeObject(lTocpPropOperationals.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TocpPropOperational tocppropoperational)
			{
				 //Create
				 db.TocpPropOperational.Add(tocppropoperational);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tocppropoperational);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TocpPropOperational tocppropoperational)
			{
				 //Update
				 db.TocpPropOperational.Update(tocppropoperational);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TocpPropOperational tocppropoperational)
			{
				 db.TocpPropOperational.Remove(tocppropoperational);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
