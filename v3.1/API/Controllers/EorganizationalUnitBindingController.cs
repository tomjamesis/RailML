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
	public class EorganizationalUnitBindingsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<EorganizationalUnitBinding> lEorganizationalUnitBindings = await db.EorganizationalUnitBinding.GetAllCompanyEorganizationalUnitBindings(id);
				 //return JsonConvert.SerializeObject(lEorganizationalUnitBindings.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]EorganizationalUnitBinding eorganizationalunitbinding)
			{
				 //Create
				 db.EorganizationalUnitBinding.Add(eorganizationalunitbinding);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(eorganizationalunitbinding);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]EorganizationalUnitBinding eorganizationalunitbinding)
			{
				 //Update
				 db.EorganizationalUnitBinding.Update(eorganizationalunitbinding);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]EorganizationalUnitBinding eorganizationalunitbinding)
			{
				 db.EorganizationalUnitBinding.Remove(eorganizationalunitbinding);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
