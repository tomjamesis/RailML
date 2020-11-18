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
	public class EderailerssController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<Ederailers> lEderailerss = await db.Ederailers.GetAllCompanyEderailerss(id);
				 //return JsonConvert.SerializeObject(lEderailerss.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]Ederailers ederailers)
			{
				 //Create
				 db.Ederailers.Add(ederailers);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(ederailers);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]Ederailers ederailers)
			{
				 //Update
				 db.Ederailers.Update(ederailers);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]Ederailers ederailers)
			{
				 db.Ederailers.Remove(ederailers);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
