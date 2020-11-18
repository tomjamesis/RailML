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
	public class EtrainGroupsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<EtrainGroup> lEtrainGroups = await db.EtrainGroup.GetAllCompanyEtrainGroups(id);
				 //return JsonConvert.SerializeObject(lEtrainGroups.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]EtrainGroup etraingroup)
			{
				 //Create
				 db.EtrainGroup.Add(etraingroup);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(etraingroup);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]EtrainGroup etraingroup)
			{
				 //Update
				 db.EtrainGroup.Update(etraingroup);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]EtrainGroup etraingroup)
			{
				 db.EtrainGroup.Remove(etraingroup);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
