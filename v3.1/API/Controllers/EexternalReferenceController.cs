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
	public class EexternalReferencesController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<EexternalReference> lEexternalReferences = await db.EexternalReference.GetAllCompanyEexternalReferences(id);
				 //return JsonConvert.SerializeObject(lEexternalReferences.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]EexternalReference eexternalreference)
			{
				 //Create
				 db.EexternalReference.Add(eexternalreference);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(eexternalreference);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]EexternalReference eexternalreference)
			{
				 //Update
				 db.EexternalReference.Update(eexternalreference);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]EexternalReference eexternalreference)
			{
				 db.EexternalReference.Remove(eexternalreference);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
