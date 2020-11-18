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
	public class EsignalGroupsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<EsignalGroup> lEsignalGroups = await db.EsignalGroup.GetAllCompanyEsignalGroups(id);
				 //return JsonConvert.SerializeObject(lEsignalGroups.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]EsignalGroup esignalgroup)
			{
				 //Create
				 db.EsignalGroup.Add(esignalgroup);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(esignalgroup);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]EsignalGroup esignalgroup)
			{
				 //Update
				 db.EsignalGroup.Update(esignalgroup);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]EsignalGroup esignalgroup)
			{
				 db.EsignalGroup.Remove(esignalgroup);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
