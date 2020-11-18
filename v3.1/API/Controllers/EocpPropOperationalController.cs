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
	public class EocpPropOperationalsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<EocpPropOperational> lEocpPropOperationals = await db.EocpPropOperational.GetAllCompanyEocpPropOperationals(id);
				 //return JsonConvert.SerializeObject(lEocpPropOperationals.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]EocpPropOperational eocppropoperational)
			{
				 //Create
				 db.EocpPropOperational.Add(eocppropoperational);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(eocppropoperational);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]EocpPropOperational eocppropoperational)
			{
				 //Update
				 db.EocpPropOperational.Update(eocppropoperational);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]EocpPropOperational eocppropoperational)
			{
				 db.EocpPropOperational.Remove(eocppropoperational);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
