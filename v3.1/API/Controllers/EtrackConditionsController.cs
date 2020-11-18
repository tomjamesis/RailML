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
	public class EtrackConditionssController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<EtrackConditions> lEtrackConditionss = await db.EtrackConditions.GetAllCompanyEtrackConditionss(id);
				 //return JsonConvert.SerializeObject(lEtrackConditionss.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]EtrackConditions etrackconditions)
			{
				 //Create
				 db.EtrackConditions.Add(etrackconditions);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(etrackconditions);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]EtrackConditions etrackconditions)
			{
				 //Update
				 db.EtrackConditions.Update(etrackconditions);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]EtrackConditions etrackconditions)
			{
				 db.EtrackConditions.Remove(etrackconditions);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
