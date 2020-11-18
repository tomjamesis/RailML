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
	public class TderailKindsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TderailKind> lTderailKinds = await db.TderailKind.GetAllCompanyTderailKinds(id);
				 //return JsonConvert.SerializeObject(lTderailKinds.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TderailKind tderailkind)
			{
				 //Create
				 db.TderailKind.Add(tderailkind);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tderailkind);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TderailKind tderailkind)
			{
				 //Update
				 db.TderailKind.Update(tderailkind);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TderailKind tderailkind)
			{
				 db.TderailKind.Remove(tderailkind);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
