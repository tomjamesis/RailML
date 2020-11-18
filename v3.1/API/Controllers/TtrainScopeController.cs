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
	public class TtrainScopesController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TtrainScope> lTtrainScopes = await db.TtrainScope.GetAllCompanyTtrainScopes(id);
				 //return JsonConvert.SerializeObject(lTtrainScopes.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TtrainScope ttrainscope)
			{
				 //Create
				 db.TtrainScope.Add(ttrainscope);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(ttrainscope);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TtrainScope ttrainscope)
			{
				 //Update
				 db.TtrainScope.Update(ttrainscope);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TtrainScope ttrainscope)
			{
				 db.TtrainScope.Remove(ttrainscope);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
