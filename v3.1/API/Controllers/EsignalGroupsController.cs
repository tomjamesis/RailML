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
	public class EsignalGroupssController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<EsignalGroups> lEsignalGroupss = await db.EsignalGroups.GetAllCompanyEsignalGroupss(id);
				 //return JsonConvert.SerializeObject(lEsignalGroupss.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]EsignalGroups esignalgroups)
			{
				 //Create
				 db.EsignalGroups.Add(esignalgroups);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(esignalgroups);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]EsignalGroups esignalgroups)
			{
				 //Update
				 db.EsignalGroups.Update(esignalgroups);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]EsignalGroups esignalgroups)
			{
				 db.EsignalGroups.Remove(esignalgroups);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
